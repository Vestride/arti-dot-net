class Layer {

  public int num_lines;
  public int left; // Current left position
  public int right; // Current right position
  public int left_bound;
  public int right_bound;
  public int center; // Center of the stage (px)
  public int spacing; // Amount that the loop is incremented, which gives spacing between lines
  public int pts; // Number of points in one bezier curve
  public float padding; // Amount of space from the center of each side where points won't be drawn.
  public int cur_step_left = 0;
  public int cur_step_right = 0;
  public int shadowAmount;

  public boolean gravity; // Determines whether points are drawn down or up
  public boolean inverse;

  private int centerX = width / 2;
  private int controlX;
  private int anchorY;
  private int controlY;
  private int anchor2Y;

  public Layer(int num_lines, int spacing, int points, float padding, int anchorY, int controlY, int anchor2Y, boolean gravity, int shadowAmount, boolean inverse) {
    this.num_lines = num_lines;
    this.spacing = spacing;
    this.pts = points;

    this.left_bound = this.get_left_bound();
    this.right_bound = this.get_right_bound();
    this.left = this.left_bound;
    this.right = this.right_bound;
    this.center = this.left_bound + ((this.right_bound - this.left_bound) / 2);
    this.padding = (float(this.right_bound - this.left_bound)) * (padding / 2);

    this.anchorY = anchorY;
    this.controlY = controlY;
    this.anchor2Y = anchor2Y;

    this.gravity = gravity;
    this.shadowAmount = shadowAmount;
    this.inverse = inverse;
  }

  void render() {

    // Draw the left side
    if (this.padding > 0 || this.inverse) {
      if (this.left < this.center - this.padding) {
        this.render_left();
      }
    } else {
      if (this.left <= this.center - this.padding) {
        this.render_left();
      }
    }
    
    // Draw the right side
    if (this.right > this.center + this.padding) {
      this.render_right();
    }
  }

  void reset() {
    this.left = this.left_bound;
    this.right = this.right_bound;
    this.cur_step_left = 0;
    this.cur_step_right = 0;
  }
  
  void drawPoint(color colour, float x, float y) {
    smooth();
    //  strokeWeight(2);
    stroke(colour, 100);
    //fill(colour, 50);
    noFill();
    ellipse(x, y, 3, 3);
    //point(x, y);
  }

  // Blot out the sun
  void drawShadow(float x, float y, float w, float h) {
    fill(0, this.shadowAmount);
    noStroke();
    //rectMode(CENTER);
    //rect(x, y, w, h);
    ellipse(x, y, w, h);
  }

  void render_left() {
    this.controlX = this.left;

    if (this.inverse) {
      centerX = this.left_bound + (width / 5);
      controlX+= this.pts;
    }

    // We've made it through an iteration of the bezierPoints, reset our loop counter  
    if (this.cur_step_left >= this.pts) {
      this.cur_step_left = 0;
      this.left += this.spacing;
    }

    // Draw a point along the bezier curve
    float t = (float (this.cur_step_left)) / this.pts;
    float t_minus = this.gravity ? t : 1 - t;
    float x = bezierPoint(centerX, controlX, controlX, centerX, t);
    float y = bezierPoint(anchorY, controlY, controlY, anchor2Y, t_minus);
    color blended = getBlendedColor(this.cur_step_left, this.pts);
    this.drawPoint(blended, x, y);
    
    if (this.shadowAmount > 0) {
      this.drawShadow(x, y, this.left - x, 100);
    }

    this.cur_step_left++;
  }

  void render_right() {
    this.controlX = this.right;

    if (this.inverse) {
      centerX = this.right_bound - (width / 5);
      controlX-= this.pts;
    }

    // We've made it through an iteration of the bezierPoints, reset our loop counter  
    if (this.cur_step_right >= this.pts) {
      this.cur_step_right = 0;
      this.right -= this.spacing;
    }

    // Draw a point along the bezier curve
    float t = (float (this.cur_step_right)) / this.pts;
    float t_minus = this.gravity ? t : 1 - t;
    float x = bezierPoint(centerX, controlX, controlX, centerX, t);
    float y = bezierPoint(anchorY, controlY, controlY, anchor2Y, t_minus);
    color blended = getBlendedColor(this.cur_step_right, this.pts);
    this.drawPoint(blended, x, y);
    
    if (this.shadowAmount > 0) {
      this.drawShadow(x, y, this.right - x, 100);
    }
    
    this.cur_step_right++;
  }
  
  int get_left_bound() {
    return round(width/2 - ((this.num_lines * this.spacing) / 2));
  }
  
  int get_right_bound() {
    return round(width/2 + ((this.num_lines * this.spacing) / 2));
  }
  
}

