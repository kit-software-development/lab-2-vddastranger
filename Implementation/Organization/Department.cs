﻿namespace Practice.Organization
{
    /// <summary>
    ///     Скрытая реализация представления об отделе предприятия.
    /// </summary>
    internal struct Department : IDepartment
    {
        /*
         * TODO #2: Реализуйте интерфейс IDepartment для структуры Department
         */
        public Department(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
    }
}
