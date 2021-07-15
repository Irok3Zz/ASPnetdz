using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace krynkoASP1407.Data
{
    public class Game // Игра
    {
        public Guid Id { get; set; }
        public string Name { get; set; } // Название игры
        public HashSet<Developer> Developers { get; set; } // Разработчик(их может быть несколько)
        public Guid Publisher { get; set; } // Издатель
        public DateTime Release { get; set; } // Дата релиза
        public HashSet<Tag> Tags { get; set; } // Теги, жанры(напр. у Assassin's Creed 2 теги: эпоха возрождения, паркур, экшен, от 3 лица и т.д.)
    }

    public class Developer // Разработчик
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public HashSet<Game> Games { get; set; } // Игры сделаные разработчиком
        public Guid Publisher { get; set; } // Издатель, если имеется
    }
    public class Publisher // Издатель
    {
        public Guid Id { get; set; }
        public string Name { get; set; } 
        public HashSet<Developer> Developers { get; set; } // Издательство владеет несколькими разработчиками
        public HashSet<Game> Games { get; set; } // Игры от издателя 
    }
    public class Tag
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
