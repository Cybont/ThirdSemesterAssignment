interface Person {
    firstName: string;
    lastName: string;
}

function greeter(person: Person): string {
    return "Hello, " + person.firstName + " " + person.lastName;
}
let user: Person = { firstName: "John", lastName: "Doe" };

let element: HTMLDivElement = <HTMLDivElement> document.getElementById("content");
element.innerHTML = greeter(user);

// Converter class just cause
class WeightConverter{
    
    constructor(){}

    /**
     * GramsToOunces
     */
    public GramsToOunces(n : number) : number {
        return n * 0.035274;
    }

    /**
     * OuncesToGrams
     */
    public OuncesToGrams(n : number) : number {
        return n / 0.035274;
    }

}


// input elements
let OuncesField : HTMLInputElement = <HTMLInputElement> document.getElementById("Ounces");
let GramsField : HTMLInputElement = <HTMLInputElement> document.getElementById("Grams");

// buttons
let OuncesButton : HTMLButtonElement = <HTMLButtonElement> document.getElementById("OuncesBtn");
let GramsButton : HTMLButtonElement = <HTMLButtonElement> document.getElementById("GramsBtn");

// Output field
let Output : HTMLElement = document.getElementById("ConverterOutput");

// Conversion
let Converter = new WeightConverter();

OuncesButton.addEventListener("click", (e:Event) =>
 Output.innerHTML = Converter.GramsToOunces(parseFloat(GramsField.value)).toString());

 GramsButton.addEventListener("click", (e:Event) =>
 Output.innerHTML = Converter.OuncesToGrams(parseFloat(OuncesField.value)).toString());
 

//function OuncesToGrams(n : number) {
  //  return n / 0.035274;
//}
//function GramsToOunces(n : number) {
  //  return n * 0.035274;
//}

 //OuncesButton.addEventListener("click", MouseEvent => {
 //Output.innerHTML = GramsToOunces(parseFloat(GramsField.value)).toString();
//}); 

 //GramsButton.addEventListener("click", MouseEvent =>{
 //Output.innerHTML = OuncesToGrams(parseFloat(OuncesField.value)).toString();
//});
