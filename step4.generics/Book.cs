namespace step4.generics
{
    class Book : Document
    {
        public string ISBN { get; set; }
        public override string GetString()
        {
            return $"Your Document {Name} , ISBN : {ISBN}";
        }
    }
}
