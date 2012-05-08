
void getPalette(int wingspan) {
  palette.getColors(wingspan);
  colors = palette.colors;
}

color getBlendedColor(int current_line_step, int total_points) {
  float t = (float (current_line_step)) / total_points;
  float colorIndex = map(t, 0, 1, 0, 4);
  color prev = colors[floor(colorIndex)];
  color next = colors[ceil(colorIndex)];
  float colors_btwn_pts = (float (total_points)) / (colors.length - 1);
  int current_color_step = round((current_line_step % colors_btwn_pts) + 1);
  float blend_amount = constrain(current_color_step / colors_btwn_pts, 0, 1);
  color blended = lerpColor(prev, next, blend_amount);
  return blended;
}

// Restart the pde
void reset() {
  background(0);
  if (layers != null) {
    for(int i = 0; i < layers.length; i++) {
      layers[i].reset();
    }
  }
  layers = null;
}

// Restart the pde
void replay() {
  noLoop();
  reset();
  ready();
}

//void mousePressed() {
//  if (mouseButton == RIGHT) {
//    noLoop();
//    println("WHY WOULD YOU STOP MAKING BEAUTIFUL ART???");
//  } 
//  else {
//    loop();
//    artifactIndex++;
//    if (artifactIndex >= artifacts.length) artifactIndex = 0;
//    artifactData = artifacts[artifactIndex];
//    replay();
//  }
//}

// void keyPressed() {
//   if ( key == ENTER ) {
//     println("You hit enter =]");
//     //endRecord();
//     exit();
//     //println("pdf saved bitches.");
//   }
// }

