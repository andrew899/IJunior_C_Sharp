namespace IJuniorHomeWork
{
    internal class Player
    {
        private string _name;
        private string _surname;

        public Player(string name, string surname)
        {
            this._name = name;
            this._surname = surname;
        }

        public string GetName() { return _name; }
        public string GetSurname() { return _surname; }
        public string GetFullName() { return _name + " " + _surname; }
    }
}