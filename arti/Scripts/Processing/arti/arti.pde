//import processing.pdf.*;

Layer[] layers;

//JSArtifact artifactData;
//JSArtifact[] artifacts;
//int artifactIndex = 0;

Palette palette;

color[] colors;

void setup() {
  noLoop();
  size(520, 770);
  smooth();
  background(0);
  frameRate(300);
  noFill();
  colorMode(RGB, 255, 255, 255, 100);

  palette = new Palette();

  // Matt's data
  //JSArtifact matt = new JSArtifact("artifact_2039", true, /*lhandX*/ 269.9736, /*lhandY*/ 319.9051, /*rhandX*/ 366.1822, /*rhandY*/ 411.843, /*wingspan*/ 661, /*leg*/ 563, /*arm*/ 185, /*head*/ 214, /*torso*/ 286, /*height*/ 276, /*bbox*/ 560, /*frame*/ 0);
  //JSArtifact weez = new JSArtifact("artifact_5491", true, /*lhandX*/ 271.3583, /*lhandY*/ 188.4483, /*rhandX*/ 355.6494, /*rhandY*/ 193.562, /*wingspan*/ 550, /*leg*/ 491, /*arm*/ 154, /*head*/ 228, /*torso*/ 295, /*height*/ 254, /*bbox*/ 560, /*frame*/ 0);
  //JSArtifact jess = new JSArtifact("artifact_5491", true, /*lhandX*/ 148.8705, /*lhandY*/ 231.7685, /*rhandX*/ 554.1658, /*rhandY*/ 134.062, /*wingspan*/ 465, /*leg*/ 558, /*arm*/ 176, /*head*/ 160, /*torso*/ 230, /*height*/ 285, /*bbox*/ 482, /*frame*/ 0);
  
//  artifacts = new JSArtifact[] { 
//    matt,
//    weez,
//    jess
//  };
//  
//  artifactData = artifacts[artifactIndex];
//
//  ready();
  //  ruler
  //  stroke(255);
  //  line(260, 0, 260, height);
}


void ready() {


  int distBtwnHands = round(dist(artifactData.lhandX, artifactData.lhandY, artifactData.rhandX, artifactData.rhandY));

  // -------------------------------------Recording PDF

  //beginRecord(PDF, "scheme-03.pdf");
  //println("ARTI > recording...");

  // -------------------------------------First layer

  int liness = artifactData.wingspan / 15;
  int spacing = artifactData.arm / 20;
  int pointss = artifactData.torso / 10;
  float padding = 0;
  int y1 = artifactData.head / 5;
  int cy = round(artifactData.leg / 5);
  int y2 = artifactData.height;
  boolean gravity = true;
  int shadowAmount = 12;
  boolean inverse = distBtwnHands > 150;
  Layer layer_one = new Layer(liness, spacing, pointss, padding, y1, cy, y2, gravity, shadowAmount, inverse);


  // -------------------------------------Second layer

  liness = artifactData.wingspan/15;
  spacing = artifactData.arm / 15;
  pointss = artifactData.torso / 10;
  padding = 0;
  y1 = (artifactData.height);
  cy = round(artifactData.leg / 1.5);
  y2 = round(artifactData.height * 2.5);
  gravity = false;
  inverse = false;
  shadowAmount = 6;
  Layer layer_two = new Layer(liness, spacing, pointss, padding, y1, cy, y2, gravity, shadowAmount + 10, inverse);


  // -------------------------------------2.5 layer
  
  y1 = round(artifactData.height * .75);
  cy = round(artifactData.height * 1.5);
  y2 = round(artifactData.height * 2.25);
  Layer layer_two5 = new Layer(liness, spacing + 3, pointss, .4, y1, cy, y2, gravity, shadowAmount, inverse);

  // -------------------------------------Third layer

  liness = artifactData.leg / 12;
  spacing = artifactData.arm / 14;
  pointss = artifactData.torso / 15;
  padding = 1 - float(artifactData.leg / 10) / float(artifactData.wingspan);
  y1 = round(artifactData.head / 5);
  cy = round(artifactData.leg / 1.5);
  y2 = round(height - artifactData.height * .25);
  gravity = true;
  inverse = false;
  shadowAmount = 1;
  Layer layer_three = new Layer(liness, spacing, pointss, padding, y1, cy, y2, gravity, shadowAmount + 10, inverse);



  // -------------------------------------Fourth layer - mah showda pads
  
  liness = 40;
  spacing = 10;
  pointss = 30;
  padding = 1 - float(artifactData.arm) / float(artifactData.wingspan);
  y1 = round((artifactData.height - (artifactData.head / 5)) * .875);
  cy = round((artifactData.height - (artifactData.head / 5)));
  y2 = round(artifactData.height * 2.5);
  gravity = false;
  shadowAmount = 6;
  Layer layer_four = new Layer(liness, spacing, pointss, padding, y1, cy, y2, gravity, shadowAmount, inverse);

  // -------------------------------------Fifth layer - mah nee pads
  
  liness = 40;
  spacing = 10;
  pointss = distBtwnHands / 10;
  padding = 1 - float(artifactData.arm) / float(artifactData.wingspan);
  y1 = round(height - artifactData.height * .95);
  cy = round(height - artifactData.height * .35);
  y2 = round(height - artifactData.height * .05);
  gravity = false;
  shadowAmount = 8;
  Layer layer_five = new Layer(liness, spacing, pointss, padding, y1, cy, y2, gravity, shadowAmount, inverse);

  // -------------------------------------Add new layers to our layers array

  layers = new Layer[] { 
    layer_one,
    layer_two,
    layer_two5,
    layer_three,
    layer_four,
    layer_five
  };

  // -------------------------------------Update the color palette

  //getPalette(int (random(340, 680)));
  getPalette(artifactData.wingspan);

  // -------------------------------------Let's go!

  loop();
}

void draw() {  
  if (artifactData == null || layers == null) {
    return;
  }

  for (int i = 0; i < layers.length; i++) {
    layers[i].render();
  }
}

