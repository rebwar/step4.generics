namespace step4.generics
{
    class NewsPaper : Document
    {
        public string RelaseDate { get; set; }
        public override string GetString()
        {
            return $"Your Document {Name} , relaseDate : {RelaseDate}";
            
        }
    }
}
