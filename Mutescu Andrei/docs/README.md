# Principiile SOLID



### 1.Single Responsibility Principle

Un principiu de programare care spune ca fiecare clasa/functie/modul trebuie sa fie responsabil pentru o singura parte/aspect din funcionalitatea unui program.
Acel/acea modul/clasa/functie trebuie sa fie incapsulat in intregime in partea de program de care este responsabil. 

### 2.Open-Closed Principle

Principiu direct care spune ca partile sistemului software(clase/functii/module) sa fie usor de extins dar greu de modificat.
Sa se prefere extinderea sau derivarea claselor decat modificarile in clasa de baza.

### 3.Liskov Substitution Principle (LSP)
Daca avem un tip L si un subtip S atunci obiectele lui L le putem inlocui cu obiecte de subtipul S fara ca substitutia sa afecteze corectitudinea programului P.

Pe scurt:Obiectele sa fie substituibile

Legenda:
L-tip
S-subtip
P-program

### 4.Interface Segregation Principle

Un principiu care spune ca interfetele nu trebuie sa fie mari si generale ci mici si specifice in contextul utilizarii.

### 5.Dependency Inversion Principle

Principiul spune ca modulele trebuie sa depinda de reprezentari abstracte si nu de implementari concrete.
