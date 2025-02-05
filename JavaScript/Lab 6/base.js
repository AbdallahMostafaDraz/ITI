import { Rectangle, Square } from './SquareModule.js';
import { Circle } from './CircleModule.js';


const shapes = [
    new Rectangle("Red", 10, 5),
    new Square("Blue", 4),
    new Circle("Green", 7, 5, 5),
    new Rectangle("Yellow", 8, 6),
    new Square("Pink", 10),
    new Circle("Black", 3, 2, 2)
];

shapes.forEach(shape => {
    console.log(`Area: ${shape.getArea()}`);
});
