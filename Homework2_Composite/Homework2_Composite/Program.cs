using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var squad = new Squad();
            squad.Add(new Unit(10));
            squad.Add(new Unit(10));
            squad.Add(new Unit(15));
            squad.Add(new Squad(new List<ISelectableEntity>()
            {
                new Unit(10)
            }));

            ISelectableEntity entity = squad;
            squad.MoveTo(10, 10);

            var health = new GetHealth();
            entity.Accept(health);
            Console.WriteLine(health.Result);
            
        }

        interface ISelectableEntityVisitor
        {
            void Visit(Unit unit);
            void Visit(Squad squad);
        }

        class GetHealth : ISelectableEntityVisitor
        {
            public int Result { get; private set; }

            public void Visit(Unit unit)
            {
                Result += unit.Health;
            }

            public void Visit(Squad squad)
            {
                
            }
        }

        interface ISelectableEntity
        {
            void MoveTo(int x, int y);
            void Accept(ISelectableEntityVisitor visitor);
        }

        class Unit : ISelectableEntity
        {
            public Unit(int health)
            {
                Health = health;
            }

            public int Health { get; set; }

            public void Accept(ISelectableEntityVisitor visitor)
            {
                visitor.Visit(this);
            }

            public void MoveTo(int x, int y)
            {
                Console.WriteLine($"Unit move to {x}:{y}");
            }
        }

        class Squad : ISelectableEntity
        {
            private List<ISelectableEntity> _entitiesInSquad;

            public Squad(List<ISelectableEntity> unitsInSquad)
            {
                _entitiesInSquad = unitsInSquad;
            }

            public Squad()
            {
                _entitiesInSquad = new List<ISelectableEntity>();
            }

            public void Add(ISelectableEntity entity)
            {
                _entitiesInSquad.Add(entity);
            }

            public void MoveTo(int x, int y)
            {
                foreach (var unit in _entitiesInSquad)
                {
                    unit.MoveTo(x, y);
                }
            }

            public void Accept(ISelectableEntityVisitor visitor)
            {
                foreach (var entity in _entitiesInSquad)
                {
                    entity.Accept(visitor);
                }
                visitor.Visit(this);
            }
        }
    }
}
