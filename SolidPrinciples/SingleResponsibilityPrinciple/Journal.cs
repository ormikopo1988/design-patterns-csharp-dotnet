﻿using System;
using System.Collections.Generic;

namespace SolidPrinciples.SingleResponsibilityPrinciple
{
    // Just stores a couple of journal entries
    public class Journal
    {
        private readonly List<string> entries = new List<string>();

        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
            return count; // memento pattern!
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }

        // All three below break single responsibility principle
        //public void Save(string filename, bool overwrite = false)
        //{
        //    File.WriteAllText(filename, ToString());
        //}

        //public void Load(string filename)
        //{

        //}

        //public void Load(Uri uri)
        //{

        //}
    }
}