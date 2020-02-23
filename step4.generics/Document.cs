namespace step4.generics
{
    class Document
    {
        public string Name { get; set; }
        public  virtual string GetString()
        {
            return Name;
        }
    }
}
