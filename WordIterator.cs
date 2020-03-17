﻿namespace Iterator {
    class WordIterator : Iterator {
        private readonly string[] WordsList;
        private int CurrentIndex { get; set; }
        public WordIterator(FileContent content) => this.WordsList = content.FileText.Split(' ');

        public bool HasNext() => (CurrentIndex < WordsList.Length) ? true : false;

        public string MoveNext() {
            if (HasNext()) { CurrentIndex++; }
            return WordsList[CurrentIndex - 1];
        }

        public void Remove() { }
    }
}
