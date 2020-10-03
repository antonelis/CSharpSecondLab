# Lab2 - bibliotek för hantering av geometiska figurer.

**Börja med skapa följande klass i biblioteket:**

public abstract class Shape
 {
 public abstract Vector3 Center { get; }
 public abstract float Area { get; }
}

Skapa därefter dessa två *publika abstrakta* klasser **Shape2D** och **Shape3D** som
båda ärver av Shape. I Shape2D ska du lägga till en public abstract property
**Circumference** av typ float, och i Shape3D ska du lägga till en public abstract
property **Volume** av typ float. För båda dessa properties gäller att man endast ska
kunna läsa deras värden (dvs man ska inte kunna skriva till dem).

**Fem klasser av geometriska figurer:**

Nu ska ni skapa klasser som ärver av antingen Shape2D eller Shape3D. Alla
klasserna ska implementera de abstakta properties som de ärver av respektive
klass på ett sådant sätt att de ger korrekta värden för mittpunkt(Center), omkrets,
area och volym. Om ni inte vet hur man räknar ut vissa saker, t.ex volym på ett
klot, så försök hitta formlerna på internet och implementera dem i er kod.
Alla klasser ska även override:a ToString() metoden för att skriva ut namnet på
formen tillsammans med centerpunktens position, följt av övriga värden (tex
radie, eller höjd/bredd).

De fem klasserna som ska implementeras är **Circle**, **Rectangle** och **Triangle** som
ska ärva av **Shape2D**, samt **Sphere** och **Cuboid** som ska ärva av **Shape3D**. 

**Circle (Shape2D)**

Klassen Circle ska ha en (1) konstruktor som tar en Vector2 center som första
parameter, och en float radius som andra parameter. Den ska override:a
ToString() på så sätt att t.ex:
Console.WriteLine(new Circle(new Vector2(3.0f, 4.0f), 2.0f));
=> “**circle @(3.0, 4.0): r = 2.0**”

**Rectangle (Shape2D)**

Denna klass ska ha en konstruktor som tar parametrar: Vector2 center, Vector2
size (dvs. höjd/bredd), samt en alternativ konstruktor: Vector2 center, float width
(som sätter både höjd och bredd till samma värde).
Den ska även implementera en property IsSquare som returnerar true om höjd
och bredd är lika (annars false).
ToString() => “**rectangle @(3.0, 4.0): w = 4.0, h = 5.0**” (square om w == h).

**Triangle (Shape2D)**

Konstruktorn tar tre parameterar p1, p2, p3 av typ Vector2, som beskriver de tre
punkter som utgör triangeln. Tänk på att Center också behöver beräknas.
ToString() => “**triangle @(3.0, 1.0): p1(0.0, 0.0), p2(3.0, 3.0), p3(6.0. 0.0)**”

**Cuboid (Shape3D)**

Denna klass ska ha en konstruktor som tar parametrar: Vector3 center, Vector3
size (dvs. höjd/bredd/djup), samt en alternativ konstruktor: Vector3 center, float
width (som sätter höjd, bredd djup till samma värde).
Den ska även implementera en property IsCube som returnerar true om höjd,
bredd och djup är lika (annars false).
ToString() => “**cuboid @(3.0, 4.0, 5.0): w = 4.0, h = 5.0, l=2.0**” (cube om w == h ==
l). 

**Sphere (Shape3D)**

Konstruktor med parametrarna Vector3 center, float radius.
ToString() => “**sphere @(0.0, 1.0, 0.0): r = 3.2**”

## Lägg till metod för att generera random shapes

När ni är klara med alla klasser ska ni lägga till en publik statisk metod
**GenerateShape** i basklassen **Shape**. Denna metod ska slumpa ett tal 0-6 för att
instantiera en av 7 figurer (circle, rectangle, square, triangle, cuboid, cube,
sphere) och returnera i form av en Shape.

De olika figurernas värden ska också slumpas. GenerateShape kommer alltså
behöva anropa konstruktorn för de olika klasserna med randomvärden på alla
parameterar.

Men, vi vill också att GenerateShape ska finnas i två utföranden, en som inte tar
några parametrar (dvs alla värden slumpas), och en där man kan skicka in en
Vector3 position för att ange mittpunkten på figuren (då slumpas endast övriga
värden såsom bredd, radie etc). Tänk på att till klasser som ärver av Shape3D kan
ni skicka in position som den är, medan ni får skapa en Vector2 av X och Y, för de
klasser som ärver av Shape2D (och alltså tar en Vector2 för mittpunkt).
Tänk också på att för Triangle kan ni bara slumpa två av punkterna. Den tredje
punkten måste räknas ut för att få mittpunkten på rätt ställe.

## Skapa ett projekt i samma solution som använder sig av ert class library

Detta projekt ska skapa en lista med _**20 random shapes**_, genom att anropa
**GenerateShape()**. Loopa sedan igenom listan och skriv ut alla shapes till konsollen.
Räkna samtidigt ut summan av omkretserna på alla trianglar i listan,
den genomsnittliga arean av alla Shapes i listan,
samt hitta den Shape3D som har störst volym av alla i listan.
Presentera detta snyggt och tydligt på konsollen när loopen är klar.
