using System;

namespace Practice.Common
{
    /// <summary>
    ///     Скрытая реализация представления об имени человека.
    /// </summary>

    public static class Extenstions
    {
        public static string NormalizedName(this string s)
        {
            s = s.ToLower();
            return Char.ToUpper(s[0]) + s.Substring(1);
        }
    }
    internal struct Name : IName
    {
        /*
         * TODO #1: Реализуйте интерфейс IName для структуры Name
         */

        /// <summary>
        ///     Имя.
        /// </summary>
        public string FirstName { get; }
        
        /// <summary>
        ///     Фамилия.
        /// </summary>
        public string Surname { get; }
        
        /// <summary>
        ///     Отчество.
        /// </summary>
        public string Patronymic { get; }

        public string FullName => Surname + " " + FirstName + " " + Patronymic;
        public string ShortName => Surname + " " + FirstName[0] + ". " + Patronymic[0] + ".";
        
        public Name(string surname, string firstname, string patronymic)
        {
            FirstName = firstname.Trim().NormalizedName();
            Surname = surname.Trim().NormalizedName();
            Patronymic = patronymic.Trim().NormalizedName();
        }

        public Name(IName name)
        {
            var arr = name.FullName.Split(' ');
            Surname = arr[0].Trim().NormalizedName();;
            FirstName = arr[1].Trim().NormalizedName();;           
            Patronymic = arr[2].Trim().NormalizedName();;
        }
        
    }
}
