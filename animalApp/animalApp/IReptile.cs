namespace animalApp
{
    public interface IReptile : IAnimal
    {
        public int Grandeur { get; set; }
        public string deplacement();
    }
}