Demo1();
Demo2();
Demo3();
Opgave1();
Opgave2();


void Demo1()
{
    Console.WriteLine("---- Demo 1 ----");
    Console.WriteLine("Vi vil beregne sinus til 90 grader med 'Math.Sin(90)' og får: ");
    Console.WriteLine(Math.Sin(90));
    Console.WriteLine("Det passer bestemt ikke, da det jo gerne skulle give 1.");
    Console.WriteLine("Det er fordi, de trigonometriske funktioner altid regner i radianer og ikke grader!");
    Console.WriteLine("Vi skal altså først omregne grader til radianer ved at gange med pi og dele med 180.");
    Console.WriteLine("Vi prøver med 'Math.Sin(90 * Math.PI/180)' og får:");
    Console.WriteLine(Math.Sin(90 * Math.PI / 180));
    Console.WriteLine("hvilket er meget bedre.");
    Console.WriteLine();
}

void Demo2()
{
    Console.WriteLine("---- Demo 2 ----");
    Console.WriteLine("Vi vil beregne invers cosinus til 0.5 hvilket skal 60 grader.");
    Console.WriteLine("Vi prøver med 'Math.Acos(0.5)' og får:");
    Console.WriteLine(Math.Acos(0.5));
    Console.WriteLine("Problemet er igen, at den beregnede vinkel er i radianer, så vi skal selv omregne til grader");
    Console.WriteLine("ved at gange med 180 og dele med pi.");
    Console.WriteLine("Vi prøver med 'Math.Acos(0.5) * 180/Math.PI' og får:");
    Console.WriteLine(Math.Acos(0.5) * 180 / Math.PI);
    Console.WriteLine("hvilket er hvad vi ønsker.");
    Console.WriteLine();
}

void Demo3()
{
    Console.WriteLine("---- Demo 3 ----");
    Console.WriteLine("For at gøre det nemmere at omregne mellem grader og radianer har vi lavet");
    Console.WriteLine("metoderne Grad2Rad og Rad2Grad.");
    Console.Write("Grad2Rad(180)       giver: ");
    Console.WriteLine(Grad2Rad(180));
    Console.Write("Rad2Grad(3.1415927) giver: ");
    Console.WriteLine(Rad2Grad(3.1415927));
    Console.WriteLine("hvilket er præcist som vi ønsker.");
    Console.WriteLine();
}

void Opgave1()
{
    // Vi har en trekant med sidelængderne 3, 4 og 5
    double a = 3;
    double b = 4;
    double c = 5;

    // Trekantens vinkler er
    double vA;
    double vB;
    double vC;

    vC = CosRelationVinkel(a, b, c);
    vB = CosRelationVinkel(a, c, b);
    vA = CosRelationVinkel(b, c, a);

    Console.WriteLine("---- Opgave 1 ----");
    Console.WriteLine("Følgende oplysninger er givet");
    Console.WriteLine($"  a : {a}");
    Console.WriteLine($"  b : {b}");
    Console.WriteLine($"  c : {c}");
    Console.WriteLine("Følgende oplysninger er beregnet");
    Console.WriteLine($"  A : {vA} grader");
    Console.WriteLine($"  B : {vB} grader");
    Console.WriteLine($"  C : {vC} grader");
    Console.WriteLine();
}

void Opgave2()
{
    // Vi har en trekant med sidelængderne 3 og 4 vinklen mellem dem er 80 grader
    double a = 3;
    double b = 4;
    double c;

    // Trekantens vinkler er
    double vA;
    double vB;
    double vC = 80;

    c = CosRelationSide(a, b, vC);
    vA = CosRelationVinkel(b, c, a);
    vB = CosRelationVinkel(a, c, b);

    Console.WriteLine("---- Opgave 2 ----");
    Console.WriteLine("Følgende oplysninger er givet");
    Console.WriteLine($"  a : {a}");
    Console.WriteLine($"  b : {b}");
    Console.WriteLine($"  C : {vC} Grader");
    Console.WriteLine("Følgende oplysninger er beregnet");
    Console.WriteLine($"  c : {c}");
    Console.WriteLine($"  A : {vA} grader");
    Console.WriteLine($"  B : {vB} grader");
    Console.WriteLine();
}

// Metode som beregner en vinkel i en trekant ved hjælp af cosinusrelationen
double CosRelationVinkel(double side1, double side2, double side3)
{
    double vinkel;

    // Her skal indsættes kode, så den rigtige vinkel beregnes
    vinkel = Rad2Grad(Math.Acos(((side1 * side1) + (side2 * side2) - (side3 * side3)) / (2 * side1 * side2)));

    return vinkel;
}

// Metode som beregner en sidelængde i en trekant ved hjælp af cosinusrelationen
double CosRelationSide(double side1, double side2, double vinkel)
{
    double side3;

    // Her skal indsættes kode, så den rigtige sidelængde beregnes
    side3 = Math.Sqrt((side1 * side1) + (side2 * side2) - (2 * side1 * side2 * Math.Cos(Grad2Rad(vinkel))));
 
    return side3;
}



// Metode som omregner grader til radianer
double Grad2Rad(double grader)
{
    double radianer;

    radianer = grader * Math.PI / 180;
    return radianer;
}

// Metode som omregner radianer til grader
double Rad2Grad(double radianer)
{
    double grader;

    grader = radianer * 180 / Math.PI;
    return grader;
}
