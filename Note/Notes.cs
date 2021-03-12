namespace Note
{
    class Notes
    {
        public string Text { get; set; }
        public bool IsChecked { get; set; }
        public Notes(string text)
        {
            Text = text;
        }
    }
}
