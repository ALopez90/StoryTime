using System;

namespace StoryTime
{
    class Program
    {
        static void Main(string[] args)
        {
            gameTitle();
        }

        public static void gameTitle()
        {
            Console.WriteLine("Welcome to 'Fate'! This is a story where each choice you make will affect the path of your adventure. Some will have consequences, some will simply be a stand-by choice (meaning, it barely affects the plot). Feel free to attempt the other paths of this game!");
            Console.WriteLine("Press 'Enter' to begin");
            Console.ReadLine();
            Console.Clear();
            begining();
        }

        public static void begining()
        {
            string choice;

            Console.WriteLine("You wake up in a small room void of light. A series of emotions run through you; confusion, fear, panic. Panic seems to dwell longer as it seizes your heart from having no recollection of how you got here; where is 'here' anyway? As you sit up, you come to realize that you're laying on a spring mattress, a dirty one from the smell of it. A grimace makes itself clear on your visage. The sores you're feeling only making your situation worse. Your eyes widen a bit when a light suddenly appears next you; a small gasp leaing you from the surprise of it. It was a candle, but how did it light up? /Who/ lit it? How will you react?");
            Console.WriteLine("1. You shuffle away from it.");
            Console.WriteLine("2. You lean towards it.");
            Console.WriteLine("3. You swat at it in attempt to snuffle it.");
            Console.WriteLine("4. You ignore it.");
            Console.WriteLine("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "shuffle away":
                case "You shuffle away from it":
                case "You shuffle away":
                    {
                        Console.WriteLine("You shuffle away from the light. The warmth of it making you doubt your surroudings. Are they trying to make me feel comortable here? Am I safe? Have I been kidnapped? You being to feel anxious, waiting for someone to appear... or something.");
                        Console.WriteLine("A laugh echoes around you; it was a deep, filled with mirth. Your eyes dart all around you, trying to pinpoint the source. You want to demand for their name, to show themselves, but you're too afraid.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        fear();
                        break;
                    }
                case "2":
                case "lean towards it":
                case "You lean towards it":
                    {
                        Console.WriteLine("You lean towards the light. You glance at it curiously. How did that happen? The wax of the candle has melted droplets decorating the rim of it; it has clearly been used before. You look around trying to learn more of your surroundings.");
                        Console.WriteLine("A laugh echoes around you; it was deep, filled with mirth. Your eyes glance around once again, trying to pinpoint the source. You wonder who it might be; what it might be. Though a bit cautious, you speak up; 'Who's there?'");
                        Console.WriteLine("Press 'Enter to continue.'");
                        Console.ReadLine();
                        curious();
                        break;
                    }
                case "3":
                case "swat":
                case "swat at it":
                case "snuffle it":
                case "snuffle it out":
                case "You swat at it in attempt to snuffle it out":
                    {
                        Console.WriteLine("You swat at the candle in attempt to snuffle it out. You hiss a bit at the feel of the fire against your skin; your attempt was futile. You look around accusingly, trying to find the reason for this candle being lit.");
                        Console.WriteLine("A laugh echoes around you; it was deep, filled with mirth. Your eyes glance around once again, trying to pinpoint the source. Your brows furrow in frustration of not being able to find them. You speak up, your voice firm and loud, 'Who's there? Show yourself!'");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        aggresive();
                        break;
                    }
                case "4":
                case "ignore":
                case "ignore it":
                case "You ignore it":
                    {
                        Console.WriteLine("You only briefly glance at it before focusing back on your situation. The candle didn't seem of importance but simply be a source of light and warmth. You look around, analyzing every little thing you can gather, but it was impossible. All you could see was darkness.");
                        Console.WriteLine("A laugh echoes around you; it was deep, filled with mirth. Your eyes glance around once again, trying to pinpoint the source. This room must be large to provide such an echo, you conclude. You don't bother speaking.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        calm();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("That's not an option. Please try again.");
                        Console.WriteLine("Press 'Enter' to try again");
                        Console.ReadLine();
                        begining();
                        break;
                    }
            }
        }

        public static void fear()
        {
            string nameOfPlayer1;

            Console.WriteLine("A chill runs down your spine when you felt a presence behind you. You freeze up as you feel it getting closer. Your breathing becomes labored when you feel someone's or something's warm breath against the nape of your neck.");
            Console.WriteLine("'Good morning, little one.' It chuckled when you flinched at hearing it's voice. 'Dare I say... I'm intrigued by you. Can't say I've seen one of your species before' A shuffle can be heard behind you and the presence disappears for a second, and only that. A pair of golden eyes, similar to the light of the candle, seem to float in front of you. Despite the flickering flame right beneath this creature, nothing besides its flaming eyes can be seen.");
            Console.WriteLine("You inhale sharply at the hunger behind its eyes. You were the prey. With each breath you take, it feels like it'll be your last.");
            Console.WriteLine("It ignored your reaction and continued talking in its terrifying voice, 'Tell me, little one, what is your name?'");
            Console.WriteLine("You pause in thought. You can't remember a thing. Where did I come from? Who am I? Frustrated, you huff a bit in thought. Letters and sounds begin to form in recognition. Finally, you reply, 'M-my name is...'");
            Console.WriteLine("Enter your name: ");
            nameOfPlayer1 = Console.ReadLine();
            Console.WriteLine("'{0} you say?' A dense pause fills the silence. It suddenly disappears from your sight!", nameOfPlayer1);
            Console.WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();
            doorway();
        }

        public static void doorway()
        {
            string choiceDoorway;

            Console.WriteLine("You look around, trying to find those burning eyes. Its voice was everywere once again; 'I'm still here' it chuckled, 'I've decided to let you choose.' Before you could ask what exactly, the candle went out and ground tremble a bit.");
            Console.WriteLine("Suddenly, you hear a rumble. It sounds like stone grind on stone. Two doorways opened; one on the left, one on the right. The left had a dim red light emitting from it, while the other held a bright white light. You couldn't see beyond the outline of the doorway due to the thick smoke that seemed to mask it.");
            Console.WriteLine("Which way will you choose?");
            Console.WriteLine("1. Left");
            Console.WriteLine("2. Right");
            Console.WriteLine("Choice: ");
            choiceDoorway = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choiceDoorway)
            {
                case "1":
                case "left":
                case "Left":
                    {
                        Console.WriteLine("You chose the left doorway. You stumble to your feet; your body still sore from sleeping on the old mattress.");
                        Console.WriteLine("You glanced around quickly before walking towards the red glow that came from the doorway.");
                        Console.WriteLine("Finally, you stand before it. Whatever was on the other side, it was clearly warm. You look back on final time before stepping into the dense fog.");
                        Console.WriteLine("Not long after walking aimlessly, the fog begins to clear up. Branches and leaves begin to appear. The flat ground beneath you begins to transform into dirt and rich green grass. Birds are chirping and the sounds of animals scurrying about anf the whistling wind surround you.");
                        Console.WriteLine("It brought you a brief sense of calm and freedom. You blink and you suddenly feel the rough texture of clothes on you. You had a tattered cotton shirt and and brown leather trousers that were a bit too short on you. You didn't even bother with clothes when you woke up, you realize. Your cheeks redden at the thought of being in front of that creature; that's embarrassing. You pause on the dirt path you found yourself on and look back once again; the doorway was no longer there.");
                        Console.WriteLine("You furrow your eyebrows in thought and wonder. You still didn't know where you were nor your background. And thus, you walk down the dirt path that layed before you.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        peasant();
                        break;
                    }
                case "2":
                case "right":
                case "Right":
                    {
                        Console.WriteLine("You chose the right doorway. You stumble to your feet; your body still sore from sleeping on the old mattress.");
                        Console.WriteLine("You glanced around quickly before walking towards the white glow that came from the doorway.");
                        Console.WriteLine("Finally, you stand before it. Whatever was on the other side, it was clearly cold. You look back on final time before stepping into the dense fog.");
                        Console.WriteLine("Not long after walking aimlessly, the fog begins to clear up. Wooden and stone walls begin to appear. The flat ground beneath you begins to tranform into stone; your footsteps echoed. You can hear the crackle of the torches that are orderly lined up every once in a while. You were in a hallway.");
                        Console.WriteLine("You felt even more confined than before. You blink and suddenly you feel the heavy weight of the armor that appeared on your body. You had chainmail and basic iron armor on; it was surprisingly heavy. You didn't even bother with clothes when you woke up, you realize. Your cheeks redden at the thought of being in front of that creature; that's embarrassing. You pause in the middle of the hallway and look back once again; the doorway was no longer there.");
                        Console.WriteLine("You furrow your eyebrows in thought and wonder. You still didn't know where you were nor your background. And thus, you walk down the hallway that layed before you.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        knight();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("That's not an option. Please try again.");
                        Console.WriteLine("Press 'Enter' to try again");
                        Console.ReadLine();
                        doorway();
                        break;
                    }
            }
        }

        public static void curious()
        {
            string nameOfPlayer2;

            Console.WriteLine("Your eyes widen slightly at the sudden presence behind you. Despite the sudden fear encompassing your heart, you begin to turn your head to look behind you. However, you pause upon feeling it come closer. Close enough to feel its breath against your skin.");
            Console.WriteLine("'Good morning, little one.' It chuckled when you clenched your jaw at hearing it's voice. 'Dare I say... I'm intrigued by you. Can't say I've seen one of your species before' A shuffle can be heard behind you and the presence disappears for a second, and only that. A pair of golden eyes, similar to the light of the candle, seem to float in front of you. Despite the flickering flame right beneath this creature, nothing besides its flaming eyes can be seen.");
            Console.WriteLine("You gasp a little at the hunger behind its eyes. You were the prey. What is it? What is this creature that it truly believes you are the prey? Your pride stung a bit at this.");
            Console.WriteLine("It ignored your reaction and continued talking in its terrifying voice, 'Tell me, little one, what is your name?'");
            Console.WriteLine("Your brows furrowed in thought. You can't remember where you came from... you remembered your name. 'My name... hmm... my name is...'");
            Console.WriteLine("Enter your name: ");
            nameOfPlayer2 = Console.ReadLine();
            Console.WriteLine("'{0} you say?' A dense pause fills the silence. You began to open your mouth to ask for its name, but it suddenly disappeared from your sight!", nameOfPlayer2);
            Console.WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();
            doorway();
        }

        public static void aggresive()
        {
            string nameOfPlayer3;

            Console.WriteLine("Your eyes narrowed and you stiffened at the sudden presence behind you. You were ready to fight; however, before you could react, its presence was suddenly behind you. Close enough to feel its breath against the nape of your neck.");
            Console.WriteLine("'Good morning, little one.' It chuckled when you frowned at hearing it's voice. 'Dare I say... I'm intrigued by you. Can't say I've seen one of your species before' A shuffle can be heard behind you and the presence disappears for a second, and only that. A pair of golden eyes, similar to the light of the candle, seem to float in front of you. Despite the flickering flame right beneath this creature, nothing besides its flaming eyes can be seen.");
            Console.WriteLine("You knew then, upon seeing the hunger in its eyes, that you were the prey. They must have immense strength. A sense of doubt clouded your mind. Despite the inner turmoil, you remained glaring at it.");
            Console.WriteLine("It ignored your reaction and continued talking in its terrifying voice, 'Tell me, little one, what is your name?'");
            Console.WriteLine("You raise your chin a bit. Although you don't remember your background, you remembered your name, 'My name is '");
            Console.WriteLine("Enter your name: ");
            nameOfPlayer3 = Console.ReadLine();
            Console.WriteLine("'{0} you say?' A dense pause fills the silence. 'What's it to you?' you snarl. Before you could get a response, it suddenly disappeared from your sight!", nameOfPlayer3);
            Console.WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();
            doorway();
        }

        public static void calm()
        {
            string nameOfPlayer4;

            Console.WriteLine("A chill ran down your spine at the presence that was suddenly behind you. This was the creature that spoke; you can tell by the similar vibe you got from the laugh. In fear of irking it, you remained looking ahead as its presence got closer. Close enough to feel its breath against your skin.");
            Console.WriteLine("'Good morning, little one.' It chuckled at your indifference upon hearing it's voice. 'Dare I say... I'm intrigued by you. Can't say I've seen one of your species before' A shuffle can be heard behind you and the presence disappears for a second, and only that. A pair of golden eyes, similar to the light of the candle, seem to float in front of you. Despite the flickering flame right beneath this creature, nothing besides its flaming eyes can be seen.");
            Console.WriteLine("This... this mattered to you because you knew then that this creature saw you as it prey. That much was clear from the hunger in its eyes. Despite your indifferent outlook, you were ready to fight if it truly came down to it.");
            Console.WriteLine("It ignored your reaction and continued talking in its terrifying voice, 'Tell me, little one, what is your name?'");
            Console.WriteLine("Your gaze is steady on it, not wanting to let it out of your sight. You can only remember your name, you realize. You have no idea what your name encompasses though. 'My name is '");
            Console.WriteLine("Enter your name: ");
            nameOfPlayer4 = Console.ReadLine();
            Console.WriteLine("'{0} you say?' A dense pause fills the silence. It suddenly disappears from your sight!", nameOfPlayer4);
            Console.WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();
            doorway();
        }

        public static void peasant()
        {
            Console.WriteLine("You come across a small village. Just based on first glance, it was a poor village. Farmers were working hard under the glare of the sun. Wives were scurrying about yelling for their children.");
            Console.WriteLine("Your pace slows down a bit as you look around. A few look at you, but their attention quickly divert back to their tasks. A delicious smell wafts in your general area. Your stomach growled in response. You hand rested against your stomach as you looked around.");
            Console.WriteLine("You're hungry. Where do I get some food? You thought as you glanced around in the middle of the village.");
            Console.WriteLine("To be continued...");
        }

        public static void knight()
        {
            Console.WriteLine("The hallway eventually leads to a grand hall. There were rows upon rows of dining tables, each side lined with plain wooden chairs. There were many people seated and enjoying the feast before them.");
            Console.WriteLine("You slowed down your pace and looked around. They were all clad in armor; some even had their helms on. The smell of roasted chicken engulfed your senses and your stomach growled loudly.");
            Console.WriteLine("You're hungry. Should I just sit down and eat? Am I allowed to? You thought as your eyes moved from one plate of food to the next.");
            Console.WriteLine("To be continued...");
        }

        public static void gameOver()
        {
            Console.WriteLine("You have failed. Game over");
        }

        public static void youWin()
        {
            Console.WriteLine("Congratulations! This is the end of your adventure. Try the other paths; see where that gets you!");
        }
    }
}
