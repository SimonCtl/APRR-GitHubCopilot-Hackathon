function setup() {
  createCanvas(800, 600);
  background(135, 206, 235); // Couleur du ciel
}

function draw() {
  // Sol
  fill(50, 205, 50);
  rect(0, height - 100, width, 100);

  // Douves
  fill(0, 191, 255);
  rect(0, height - 150, width, 50);

  // Murs du château
  fill(169, 169, 169);
  rect(200, 300, 400, 200);

  // Tours du château
  rect(150, 200, 100, 300);
  rect(550, 200, 100, 300);

  // Créneaux sur les murs
  for (let i = 200; i <= 600; i += 50) {
    rect(i, 250, 30, 50);
  }

  // Créneaux sur la tour gauche
  for (let i = 150; i <= 250; i += 25) {
    rect(i, 150, 20, 50);
  }

  // Créneaux sur la tour droite
  for (let i = 550; i <= 650; i += 25) {
    rect(i, 150, 20, 50);
  }

  // Porte
  fill(101, 67, 33);
  rect(375, 400, 50, 100);

  // Fenêtres
  fill(255);
  rect(250, 350, 30, 50);
  rect(520, 350, 30, 50);

  // Catapultes
  drawCatapult(100, 450);
  drawCatapult(700, 450);

  // Princesse
  drawPrincess(200, 150);
}

function drawCatapult(x, y) {
  // Base de la catapulte
  fill(139, 69, 19);
  rect(x - 30, y, 60, 20);

  // Bras de la catapulte
  rect(x - 5, y - 50, 10, 50);

  // Seau de la catapulte
  ellipse(x, y - 60, 30, 20);

  // Roues de la catapulte
  fill(0);
  ellipse(x - 20, y + 20, 20, 20);
  ellipse(x + 20, y + 20, 20, 20);
}

function drawPrincess(x, y) {
  // Tête
  fill(255, 224, 189);
  ellipse(x, y, 30, 40);

  // Corps
  fill(255, 105, 180);
  rect(x - 15, y + 20, 30, 50);

  // Bras
  fill(255, 224, 189);
  rect(x - 25, y + 20, 10, 40);
  rect(x + 15, y + 20, 10, 40);

  // Couronne avec plusieurs dents
  fill(255, 223, 0);
  let crownWidth = 30;
  let crownHeight = 20;
  let numTeeth = 5;
  let toothWidth = crownWidth / numTeeth;
  let crownY = y - 20;

  for (let i = 0; i < numTeeth; i++) {
    let toothX = x - crownWidth / 2 + i * toothWidth;
    triangle(toothX, crownY, toothX + toothWidth / 2, crownY - crownHeight, toothX + toothWidth, crownY);
  }
}
