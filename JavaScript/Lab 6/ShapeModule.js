export class Shape {
    #color; 

    constructor(color) {
        this.#color = color; 
    }

    get Color() {
        return this.#color;
    }

    set Color(newColor) {
         this.#color = newColor;
    }

    drawShape() {
        console.log(`The shape color is: ${this.#color}`);
    }
}

