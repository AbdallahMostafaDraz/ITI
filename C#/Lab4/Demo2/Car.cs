namespace Demo2
{
    public class Car
    {
        string model;
        string color;
        int speed, maxSpeed;

        public void SetModel(string _model) { model = _model; }
        public string GetModel() { return model;  }

        public void SetColor(string _color) { color = _color; }
        public string GetColor() { return color; }
        public void SetMaxSpeed(int _maxSpeed) { maxSpeed = _maxSpeed; }
        public int GetMaxSpeed() { return maxSpeed; }

        public void AccelerateSpeed()
        {
            if (speed < maxSpeed)
                speed =+ 5;
            else
                Console.WriteLine("Cann't Acclerate Speed. It Is Max Speed!");
        }

        public void DeAcclerateSpeed()
        {
            if (speed > 0)
                speed -= 5;
            else
                Console.WriteLine("Current Speed Is Zero!");
        }

        public int GetSpeed() {  return speed; }
        public void Print()
        {
            Console.WriteLine($"Model: {model}, Color: {color}, Current Speed: {speed}, Max Speed: {maxSpeed}");
        }

        public Car(string _model)
        {
            _model = model;
        }

        public Car(string _model, string _color) : this(_model)
        {
            color = _color;
        }

        public Car(string _model, string _color, int _maxSpeed) : this(_model, _color)
        {
            maxSpeed = _maxSpeed;
        }
    }
}
