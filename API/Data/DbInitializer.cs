using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DataContext context)
        {
            if (context.StoryLines.Any() || context.Forks.Any())
            {
                return;
            }
            context.Database.Migrate();

            var storyLines = new List<StoryLine>()
            {
                new StoryLine
                {
                    Title = "Zombies at your doorstep",
                    Description = "You suddenly awaken to news that zombies have began terrorizing your surroundings",
                    Body = "Ph'nglui mglw'nafh Cthulhu R'lyeh wgah'nagl fhtagn. Fm'latgh Yoggothagl Tsathoggua ah, nagrah'n ph'nog y-orr'e bug stell'bsna geb f'nglui mg, wgah'n naTsathoggua Azathoth y-ya shagg hlirgh chupadgh goka. Ep ngmg throd 'ai li'hee ya throd uln Tsathogguaagl ya, zhro nglui gotha ilyaa kadishtu y-vulgtlagln kn'a h'uln, shugg 'bthnk orr'e nw geb h'vulgtm tharanak vulgtm. Uaaah goka orr'e sll'ha ph'lloig shugg Tsathoggua Cthulhu Chaugnar Faugn R'lyehoth Chaugnar Faugn ph'syha'h y'hahyar, 'ai Dagonagl ph'ah s'uhn cgeb phlegeth uln eeor llll fhtagn ron. Grah'n sgn'wahl ya 'ai hupadgh ph'ftaghu nw y'hah uln gnaiihagl ooboshu geb h''bthnk goka Yoggoth nog, syha'h nahrii f'r'luh chlirgh fm'latgh hlirgh bug Tsathoggua nnnftaghu Nyarlathotep shagg hai phlegeth ya. ",
                    UserId = 1,
                    Likes = 15,

                },
                 new StoryLine
                {
                    Title = "An ode to friendship",
                    Description = "Childhood friends meet one another after years of no contact",
                    Body = "Ph'nglui mglw'nafh Cthulhu R'lyeh wgah'nagl fhtagn. Fm'latgh Yoggothagl Tsathoggua ah, nagrah'n ph'nog y-orr'e bug stell'bsna geb f'nglui mg, wgah'n naTsathoggua Azathoth y-ya shagg hlirgh chupadgh goka. Ep ngmg throd 'ai li'hee ya throd uln Tsathogguaagl ya, zhro nglui gotha ilyaa kadishtu y-vulgtlagln kn'a h'uln, shugg 'bthnk orr'e nw geb h'vulgtm tharanak vulgtm. Uaaah goka orr'e sll'ha ph'lloig shugg Tsathoggua Cthulhu Chaugnar Faugn R'lyehoth Chaugnar Faugn ph'syha'h y'hahyar, 'ai Dagonagl ph'ah s'uhn cgeb phlegeth uln eeor llll fhtagn ron. Grah'n sgn'wahl ya 'ai hupadgh ph'ftaghu nw y'hah uln gnaiihagl ooboshu geb h''bthnk goka Yoggoth nog, syha'h nahrii f'r'luh chlirgh fm'latgh hlirgh bug Tsathoggua nnnftaghu Nyarlathotep shagg hai phlegeth ya. ",
                    UserId = 1,
                    Likes = 10,

                },
                new StoryLine
                {
                    Title = "The Portsmith Horror",
                    Description = "Eldrith Horror for a new generation",
                    Body = "The feverish interest aroused at the meeting by Legrasse's tale, corroborated as it was by the statuette, is echoed in the subsequent correspondence of those who attended; although scant mention occurs in the formal publication of the society. Caution is the first care of those accustomed to face occasional charlatanry and imposture. Legrasse for some time lent the image to Professor Webb, but at the latter's death it was returned to him and remains in his possession, where I viewed it not long ago. It is truly a terrible thing, and unmistakably akin to the dream-sculpture of young Wilcox.",
                    UserId = 1,
                    Likes = 15,

                },
                new StoryLine
                {
                    Title = "Zombies",
                    Description = "Just zombies",
                    Body = "Ph'nglui mglw'nafh Cthulhu R'lyeh wgah'nagl fhtagn. Fm'latgh Yoggothagl Tsathoggua ah, nagrah'n ph'nog y-orr'e bug stell'bsna geb f'nglui mg, wgah'n naTsathoggua Azathoth y-ya shagg hlirgh chupadgh goka. Ep ngmg throd 'ai li'hee ya throd uln Tsathogguaagl ya, zhro nglui gotha ilyaa kadishtu y-vulgtlagln kn'a h'uln, shugg 'bthnk orr'e nw geb h'vulgtm tharanak vulgtm. Uaaah goka orr'e sll'ha ph'lloig shugg Tsathoggua Cthulhu Chaugnar Faugn R'lyehoth Chaugnar Faugn ph'syha'h y'hahyar, 'ai Dagonagl ph'ah s'uhn cgeb phlegeth uln eeor llll fhtagn ron. Grah'n sgn'wahl ya 'ai hupadgh ph'ftaghu nw y'hah uln gnaiihagl ooboshu geb h''bthnk goka Yoggoth nog, syha'h nahrii f'r'luh chlirgh fm'latgh hlirgh bug Tsathoggua nnnftaghu Nyarlathotep shagg hai phlegeth ya. ",
                    UserId = 2,
                    Likes = 7,

                },
                new StoryLine
                {
                    Title = "Alien",
                    Description = "Alien Invasion",
                    Body = "Ph'nglui mglw'nafh Cthulhu R'lyeh wgah'nagl fhtagn. Fm'latgh Yoggothagl Tsathoggua ah, nagrah'n ph'nog y-orr'e bug stell'bsna geb f'nglui mg, wgah'n naTsathoggua Azathoth y-ya shagg hlirgh chupadgh goka. Ep ngmg throd 'ai li'hee ya throd uln Tsathogguaagl ya, zhro nglui gotha ilyaa kadishtu y-vulgtlagln kn'a h'uln, shugg 'bthnk orr'e nw geb h'vulgtm tharanak vulgtm. Uaaah goka orr'e sll'ha ph'lloig shugg Tsathoggua Cthulhu Chaugnar Faugn R'lyehoth Chaugnar Faugn ph'syha'h y'hahyar, 'ai Dagonagl ph'ah s'uhn cgeb phlegeth uln eeor llll fhtagn ron. Grah'n sgn'wahl ya 'ai hupadgh ph'ftaghu nw y'hah uln gnaiihagl ooboshu geb h''bthnk goka Yoggoth nog, syha'h nahrii f'r'luh chlirgh fm'latgh hlirgh bug Tsathoggua nnnftaghu Nyarlathotep shagg hai phlegeth ya. ",
                    UserId = 2,
                    Likes = 5,

                },
                new StoryLine
                {
                    Title = "Zombies at your doorstep part deux",
                    Description = "ZOmbies amongs ust",
                    Body = "Ph'nglui mglw'nafh Cthulhu R'lyeh wgah'nagl fhtagn. Fm'latgh Yoggothagl Tsathoggua ah, nagrah'n ph'nog y-orr'e bug stell'bsna geb f'nglui mg, wgah'n naTsathoggua Azathoth y-ya shagg hlirgh chupadgh goka. Ep ngmg throd 'ai li'hee ya throd uln Tsathogguaagl ya, zhro nglui gotha ilyaa kadishtu y-vulgtlagln kn'a h'uln, shugg 'bthnk orr'e nw geb h'vulgtm tharanak vulgtm. Uaaah goka orr'e sll'ha ph'lloig shugg Tsathoggua Cthulhu Chaugnar Faugn R'lyehoth Chaugnar Faugn ph'syha'h y'hahyar, 'ai Dagonagl ph'ah s'uhn cgeb phlegeth uln eeor llll fhtagn ron. Grah'n sgn'wahl ya 'ai hupadgh ph'ftaghu nw y'hah uln gnaiihagl ooboshu geb h''bthnk goka Yoggoth nog, syha'h nahrii f'r'luh chlirgh fm'latgh hlirgh bug Tsathoggua nnnftaghu Nyarlathotep shagg hai phlegeth ya. ",
                    UserId = 1,
                    Likes = 25,

                },
                new StoryLine
                {
                    Title = "Zombies at your doorstep part tres",
                    Description = "Who does not like maor zeds?",
                    Body = "Ph'nglui mglw'nafh Cthulhu R'lyeh wgah'nagl fhtagn. Fm'latgh Yoggothagl Tsathoggua ah, nagrah'n ph'nog y-orr'e bug stell'bsna geb f'nglui mg, wgah'n naTsathoggua Azathoth y-ya shagg hlirgh chupadgh goka. Ep ngmg throd 'ai li'hee ya throd uln Tsathogguaagl ya, zhro nglui gotha ilyaa kadishtu y-vulgtlagln kn'a h'uln, shugg 'bthnk orr'e nw geb h'vulgtm tharanak vulgtm. Uaaah goka orr'e sll'ha ph'lloig shugg Tsathoggua Cthulhu Chaugnar Faugn R'lyehoth Chaugnar Faugn ph'syha'h y'hahyar, 'ai Dagonagl ph'ah s'uhn cgeb phlegeth uln eeor llll fhtagn ron. Grah'n sgn'wahl ya 'ai hupadgh ph'ftaghu nw y'hah uln gnaiihagl ooboshu geb h''bthnk goka Yoggoth nog, syha'h nahrii f'r'luh chlirgh fm'latgh hlirgh bug Tsathoggua nnnftaghu Nyarlathotep shagg hai phlegeth ya. ",
                    UserId = 1,
                    Likes = 50,

                },
                new StoryLine
                {
                    Title = "Lone tower in the west",
                    Description = "Spaghetti western minus the spaghetti",
                    Body = "Ph'nglui mglw'nafh Cthulhu R'lyeh wgah'nagl fhtagn. Fm'latgh Yoggothagl Tsathoggua ah, nagrah'n ph'nog y-orr'e bug stell'bsna geb f'nglui mg, wgah'n naTsathoggua Azathoth y-ya shagg hlirgh chupadgh goka. Ep ngmg throd 'ai li'hee ya throd uln Tsathogguaagl ya, zhro nglui gotha ilyaa kadishtu y-vulgtlagln kn'a h'uln, shugg 'bthnk orr'e nw geb h'vulgtm tharanak vulgtm. Uaaah goka orr'e sll'ha ph'lloig shugg Tsathoggua Cthulhu Chaugnar Faugn R'lyehoth Chaugnar Faugn ph'syha'h y'hahyar, 'ai Dagonagl ph'ah s'uhn cgeb phlegeth uln eeor llll fhtagn ron. Grah'n sgn'wahl ya 'ai hupadgh ph'ftaghu nw y'hah uln gnaiihagl ooboshu geb h''bthnk goka Yoggoth nog, syha'h nahrii f'r'luh chlirgh fm'latgh hlirgh bug Tsathoggua nnnftaghu Nyarlathotep shagg hai phlegeth ya. ",
                    UserId = 2,
                    Likes = 10,

                },
                new StoryLine
                {
                    Title = "Dragons Breath",
                    Description = "High fantasy or just high?",
                    Body = "Ph'nglui mglw'nafh Cthulhu R'lyeh wgah'nagl fhtagn. Fm'latgh Yoggothagl Tsathoggua ah, nagrah'n ph'nog y-orr'e bug stell'bsna geb f'nglui mg, wgah'n naTsathoggua Azathoth y-ya shagg hlirgh chupadgh goka. Ep ngmg throd 'ai li'hee ya throd uln Tsathogguaagl ya, zhro nglui gotha ilyaa kadishtu y-vulgtlagln kn'a h'uln, shugg 'bthnk orr'e nw geb h'vulgtm tharanak vulgtm. Uaaah goka orr'e sll'ha ph'lloig shugg Tsathoggua Cthulhu Chaugnar Faugn R'lyehoth Chaugnar Faugn ph'syha'h y'hahyar, 'ai Dagonagl ph'ah s'uhn cgeb phlegeth uln eeor llll fhtagn ron. Grah'n sgn'wahl ya 'ai hupadgh ph'ftaghu nw y'hah uln gnaiihagl ooboshu geb h''bthnk goka Yoggoth nog, syha'h nahrii f'r'luh chlirgh fm'latgh hlirgh bug Tsathoggua nnnftaghu Nyarlathotep shagg hai phlegeth ya. ",
                    UserId = 1,
                    Likes = 15,

                },
                new StoryLine
                {
                    Title = "The bells toll for no one",
                    Description = "World war thriller before the a world war",
                    Body = "Ph'nglui mglw'nafh Cthulhu R'lyeh wgah'nagl fhtagn. Fm'latgh Yoggothagl Tsathoggua ah, nagrah'n ph'nog y-orr'e bug stell'bsna geb f'nglui mg, wgah'n naTsathoggua Azathoth y-ya shagg hlirgh chupadgh goka. Ep ngmg throd 'ai li'hee ya throd uln Tsathogguaagl ya, zhro nglui gotha ilyaa kadishtu y-vulgtlagln kn'a h'uln, shugg 'bthnk orr'e nw geb h'vulgtm tharanak vulgtm. Uaaah goka orr'e sll'ha ph'lloig shugg Tsathoggua Cthulhu Chaugnar Faugn R'lyehoth Chaugnar Faugn ph'syha'h y'hahyar, 'ai Dagonagl ph'ah s'uhn cgeb phlegeth uln eeor llll fhtagn ron. Grah'n sgn'wahl ya 'ai hupadgh ph'ftaghu nw y'hah uln gnaiihagl ooboshu geb h''bthnk goka Yoggoth nog, syha'h nahrii f'r'luh chlirgh fm'latgh hlirgh bug Tsathoggua nnnftaghu Nyarlathotep shagg hai phlegeth ya. ",
                    UserId = 2,
                    Likes = 2,

                },
                new StoryLine
                {
                    Title = "Not another teen romcom",
                    Description = "Always be my something",
                    Body = "Ph'nglui mglw'nafh Cthulhu R'lyeh wgah'nagl fhtagn. Fm'latgh Yoggothagl Tsathoggua ah, nagrah'n ph'nog y-orr'e bug stell'bsna geb f'nglui mg, wgah'n naTsathoggua Azathoth y-ya shagg hlirgh chupadgh goka. Ep ngmg throd 'ai li'hee ya throd uln Tsathogguaagl ya, zhro nglui gotha ilyaa kadishtu y-vulgtlagln kn'a h'uln, shugg 'bthnk orr'e nw geb h'vulgtm tharanak vulgtm. Uaaah goka orr'e sll'ha ph'lloig shugg Tsathoggua Cthulhu Chaugnar Faugn R'lyehoth Chaugnar Faugn ph'syha'h y'hahyar, 'ai Dagonagl ph'ah s'uhn cgeb phlegeth uln eeor llll fhtagn ron. Grah'n sgn'wahl ya 'ai hupadgh ph'ftaghu nw y'hah uln gnaiihagl ooboshu geb h''bthnk goka Yoggoth nog, syha'h nahrii f'r'luh chlirgh fm'latgh hlirgh bug Tsathoggua nnnftaghu Nyarlathotep shagg hai phlegeth ya. ",
                    UserId = 2,
                    Likes = 0,

                },
            };

            foreach (var story in storyLines)
            {
                context.StoryLines.Add(story);
            }

            // var forks = new List<Fork>()
            // {
            //     new Fork
            //     {
            //         Body = "Shub-Niggurath Tsathoggua fm'latgh nagoka ngchtenff k'yarnak gof'nn R'lyeh shtunggli uaaah r'luh ch'",
            //         UserId = 1,
            //         StoryLineId = 1,
            //         Likes = 10
            //     },
            //     new Fork
            //     {
            //         Body = "Shub-Niggurath Tsathoggua fm'latgh nagoka ngchtenff k'yarnak gof'nn R'lyeh shtunggli uaaah r'luh ch'",
            //         UserId = 1,
            //         StoryLineId = 1,
            //         Likes = 10
            //     },
            //     new Fork
            //     {
            //         Body = "Shub-Niggurath Tsathoggua fm'latgh nagoka ngchtenff k'yarnak gof'nn R'lyeh shtunggli uaaah r'luh ch'",
            //         UserId = 2,
            //         StoryLineId = 2,
            //         Likes = 10
            //     },
            //     new Fork
            //     {
            //         Body = "Shub-Niggurath Tsathoggua fm'latgh nagoka ngchtenff k'yarnak gof'nn R'lyeh shtunggli uaaah r'luh ch'",
            //         UserId = 2,
            //         StoryLineId = 3,
            //         Likes = 10
            //     },
            //     new Fork
            //     {
            //         Body = "Shub-Niggurath Tsathoggua fm'latgh nagoka ngchtenff k'yarnak gof'nn R'lyeh shtunggli uaaah r'luh ch'",
            //         UserId = 1,
            //         StoryLineId = 2,
            //         Likes = 10
            //     },
            //     new Fork
            //     {
            //         Body = "Shub-Niggurath Tsathoggua fm'latgh nagoka ngchtenff k'yarnak gof'nn R'lyeh shtunggli uaaah r'luh ch'",
            //         UserId = 1,
            //         StoryLineId = 1,
            //         Likes = 10
            //     },
            // };

            // foreach (var fork in forks)
            // {
            //     context.Forks.Add(fork);
            // }

            context.SaveChanges();
        }
    }
}