using Practice.Common;
using Practice.HR.Events;
using System;

namespace Practice.HR
{
    /// <summary>
    ///     Абстрактная база для описания конкретных реализаций типа "Человек".
    ///     Используется для дальнейшего наследования.
    /// </summary>
    internal abstract class AbstractPerson : IPerson
    {
        private IName _name;

        public IName Name
        {
            get => _name;

            set
            {
                var args = new ValueChangeEventArgs<IName>(_name);
                _name = value;
                NameChange?.Invoke(this, args);
            }
        }

        public event EventHandler<ValueChangeEventArgs<IName>> NameChange;
        
        /*internal Organization.Department Department
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }
        internal Common.Name Name
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }*/

        /*
         * TODO #3: Реализуйте интерфейс IPerson для класса AbstractPerson
         */
    }
}