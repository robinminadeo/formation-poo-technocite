namespace animalApp
{
    public interface IOiseau : IAnimal
    {
        public TypeOiseau Type { get; set; }
        public string chasse();
    }
}