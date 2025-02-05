import { Shape } from './shapeModule.js';

export class Circle extends Shape {
    constructor(color, radius, x, y) {
        super(color); 
        this.radius = radius;
        this.x = x;
        this.y = y;
    }

    getArea() {
        this.drawShape(); 
        return Math.PI * Math.pow(this.radius, 2);
    }
}

