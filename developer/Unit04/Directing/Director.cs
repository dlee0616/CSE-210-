using System.Collections.Generic;
using Greed.Casting;
using Greed.Services;

namespace Greed
{
    public class Director
    {   
        private KeyboardService _keyBoard = null;
        private VideoService _video = null;
        //make keyboard and vdieo into parameters
        public Director(KeyboardService keyBoard, VideoService video)
        {
            this._keyBoard = keyBoard;
            this._video = video;

        }
        //start game 
        public void ExecuteGame(Cast cast)
        {
            _video.OpenWindow();
            while (_video.OpenWindow())
            {
                GetInputs(cast);
                DoUpdates(cast);
                DoOutput(cast);
            }
            _video.CloseWindow();

        }
       

        // get keyboard inputs and apply to avatar 
        private void GetMove(Cast cast)
        {
            Actor avatar = cast.GetFirstActor("avatar");
            Point velocity = _keyBoard.GetDirection();
            avatar.SetVelocity(velocity);


        }
        private void DoUpdates(Cast cast)
        {
            Actor banner = cast.GetFirstActor("banner");
            Actor avatar = cast.GetFirstActor("avatar");
            List<actor> artifacts = cast.GetActors("artifacts");
            banner.SetText("");
            int maxX = _video.GetWidth();
            int maxY = _video.GetHeight();
            avatar.MoveNext(maxX, maxY);

            foreach (Actor actor in artifacts)
            {   
                if (avatar.GetPosition().Equals(actor.GetPosition()))
                {
                    Artifact artifact = (Artifact) actor;
                    string message = artifact.GetMessage();
                    banner.SetText(message);
                }

            }

        }
        public void Outputs()
            {
                
            List<Actor> actors = cast.GetAllActors();
            _video.ClearBuffer();
            _video.DrawActors(actors);
            _video.FlushBuffer();

            }

    
    }

}

// Standard practice is to put ONE class in each file
// The name of the file should match the name of the class
// inside the file

// The names of variables should be in camel case. Starts lower case and 
// has upper for each new word
// ex. firstName, lastName

// The names of files, namespaces classes and functions should be capitalized.