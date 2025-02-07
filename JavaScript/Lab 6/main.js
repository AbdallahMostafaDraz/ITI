// task1. arrow functoion
arr = [20,7,8,10,89,100,45,17]

// a. With Array.filter() function, to return the odd numbers from an array. 
var getOddNumbers = arr => arr.filter(element => element % 2 !== 0);

console.log(getOddNumbers(arr));


// b. With array.forech() to print the even values. 
var evenNumbers = [];
var getEvenNumber = arr => arr.forEach((element) => {
    if (element % 2 === 0)
        evenNumbers.push(element);
} );
getEvenNumber(arr)
console.log(evenNumbers)

// c. With array.sort() to print sorted arr asc and des. 

var arrSortedASC = arr => arr.sort((a, b) => a - b);
console.log(arrSortedASC(arr));

var arrSortedDESC = arr => arr.sort((a, b) => b - a);
console.log(arrSortedDESC(arr));

// ==================================================================================

// Task2 
var myArr = [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]

// 1. for ... in (loops through indexes)
console.log("Loop Using For ... in")
for(index in myArr)
{
    console.log(index, myArr[index])
}

// 2. for ... of (loops thorugh values)
console.log("Loop Using For ... of")
for (value of myArr)
{
    console.log(value)
}

// 3. foreach
myArr.forEach((value, index) => {
    console.log(index, value);
});


// for .. in  & foreach  : can access index
// for .. in  & for .. of : can break loop 

// ====================================================================================
// Task 3: Create function to do operations like (+,-,*,/) on its params  

// A- Using eval  
function calculateUsingEval(a, operator, b) {
    return eval(`${a} ${operator} ${b}`);
}
console.log(calculateUsingEval(10, '+', 20))

// B- Using rest operator
function calculate(operator, ...numbers) {
    if (numbers.length < 2) {
        return "At least two numbers are required.";
    }
    return eval(arr.join(operator));
}

console.log(calculate("+", 10, 200))


// =========================================================================================
// Task 4: Create an arrow function that returns an object representing a rectangle 
// with properties for its width and height, and a method to calculate its area.
var createRectangle = (width, height) => ({
    width,
    height,
    calculateArea: function() {
        return this.width * this.height;  
    }
});

rect = createRectangle(5, 10);

console.log("Width:", rect.width); 
console.log("Height:", rect.height);
console.log("Area:", rect.calculateArea()); 


// ===========================================================================================
// // Task 5: 
// Create a predefined list of objects representing students, each with a 
// name and grade. Then, use an arrow function to find and log the names 
// of students who passed (grade >= 50).

const students = [
    { name: "Abdallah", grade: 99 },
    { name: "Ahmed", grade: 45 },
    { name: "Mostafa", grade: 55 },
    { name: "Ali", grade: 90 },
    { name: "Omar", grade: 30 }
];

getGradesLargerThan50 = (students) => {
    passed = students.filter(element => element.grade >= 50);
    passed.forEach(element => console.log(element.name));
}

getGradesLargerThan50(students);

// ============================================================================================
// Task 6:
// 6. Use object destructuring to extract properties from an object into individual variables. 
let student = {
    name: "Abdallah",
    age: 24,
    grade: 99,
    subject: "JS"
};

let { name, age, grade, subject } = student;

console.log(name);    
console.log(age);     
console.log(grade);   
console.log(subject); 

// =================================================================================================
// Task 7:
// 7. Create a simple factory function that generates objects representing cars. 
function createCar(make, model, year) {
    return {
        make,
        model,
        year,
        displayInfo() {
            return `${this.make} ${this.model} ${year}`;
        }
    };
}

// Example usage:
const car1 = createCar("Toyota", "Corolla", 2020);
const car2 = createCar("Hundai", "Alentra", 2018);

console.log(car1.displayInfo()); 
console.log(car2.displayInfo()); 

// =====================================================================================================

// Task 8:
// 8. Create a factory function to represent different geometric shapes. 
// Factory function to create different shapes
function createShape(type, dimensions) {
    let shape = {
        type,
        dimensions,

        calculateArea() {
            if (this.type === "rectangle") {
                return this.dimensions.width * this.dimensions.height;
            } else if (this.type === "circle") {
                return Math.PI * Math.pow(this.dimensions.radius, 2);
            } else if (this.type === "triangle") {
                return 0.5 * this.dimensions.base * this.dimensions.height;
            } else {
                return "Invalid shape type";
            }
        }
    };
    return shape;
}

const rectangle = createShape("rectangle", { width: 10, height: 5 });
const circle = createShape("circle", { radius: 7 });
const triangle = createShape("triangle", { base: 6, height: 4 });

console.log(`Rectangle: ${rectangle.type}, Area: ${rectangle.calculateArea()}`);  
console.log(`Circle: ${circle.type}, Area: ${circle.calculateArea()}`);          
console.log(`Triangle: ${triangle.type}, Area: ${triangle.calculateArea()}`);    
