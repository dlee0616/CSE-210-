using System.Collections.Generic;


namespace Greed.Casting
{
   
    public class Cast
    {
        private Dictionary<string, List<Actor>> _actors = new Dictionary<string, List<Actor>>();

        /// Constructs a new instance of Cast.
        public Cast()
        {
        }

       
        public void AddActor(string group, Actor actor)
        {
            if (!_actors.ContainsKey(group))
            {
                _actors[group] = new List<Actor>();
            }

            if (!_actors[group].Contains(actor))
            {
                _actors[group].Add(actor);
            }
        }

        //get actors in group
        public List<Actor> GetActors(string group)
        {
            List<Actor> results = new List<Actor>();
            if (_actors.ContainsKey(group))
            {
                results.AddRange(_actors[group]);
            }
            return results;
        }

   
        /// Gets all the actors in the cast.
       
        public List<Actor> GetAllActors()
        {
            List<Actor> results = new List<Actor>();
            foreach (List<Actor> result in _actors.Values)
            {
                results.AddRange(result);
            }
            return results;
        }

        //get first actor 
        public Actor GetFirstActor(string group)
        {
            Actor result = null;
            if (_actors.ContainsKey(group))
            {
                if (_actors[group].Count > 0)
                {
                    result = _actors[group][0];
                }
            }
            return result;
        }

        // remove first actor 
        public void RemoveActor(string group, Actor actor)
        {
            if (_actors.ContainsKey(group))
            {
                _actors[group].Remove(actor);
            }
        }

    }
}