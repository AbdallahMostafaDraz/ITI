import { Shape } from './shapeModule.js';

export class Rectangle extends Shape {
    constructor(color, width, height) {
        super(color); 
        this.width = width;
        this.height = height;
    }

    getArea() {
        this.drawShape(); 
        return this.width * this.height;
    }
}

export class Square extends Rectangle {
    constructor(color, side) {
        super(color, side, side); 
    }
}

