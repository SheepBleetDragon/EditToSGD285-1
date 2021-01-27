/********************************************************************
	created:	2017/01/28
	created:	28:1:2017   17:09
	filename: 	Main.cs
	file path:	SGD285-1
	file base:	Main
	file ext:	cs
	author:		Bahram Dahi

	purpose:	This program is a simple C# app that displays
                quotes from the students' favorite authors.

    Last Update:
                . Added the UserQuote for Bahram Dahi
*********************************************************************/
using System;

public class SGD285_1
{
    // Do not modify this structure
    public struct UserQuote
    {
        public string Name;
        public string Quote;
        public UserQuote(string name, string quote)
        {
            Name = name;
            Quote = quote;
        }
    }

    // Main method
    public static void Main()
    {
        UserQuote[] userQuotes = new UserQuote[]
	    {
            new UserQuote("Brandon Mam", "The greatest glory in living lies not in never falling, but in rising every time we fall. -Nelson Mandela"),
           new UserQuote("Israel Harvin", "Be Water, My Friend. Empty your mind. Be formless, shapeless, like water. You put water into a cup, it becomes the cup. You put water into a bottle, it becomes the bottle. You put it into a teapot, it becomes the teapot. Now water can flow or it can crash. Be water, my friend. -Bruce Lee"),
           new UserQuote("Bahram Dahi", "I have never let my schooling interfere with my education. - [attributed to] Mark Twain"),
	       new UserQuote("Ryan Douglass", "If there is no struggle there is no progress. - Frederick Douglass"),
	       new UserQuote("Baylen Smith", "Whatever happens, happens. - Spike Spiegel"),
	       new UserQuote("Jennifer Ethridge", "I have found a desire within myself that no experience in this world can satisfy; the most probable explanation is that I was made for another world."),
           new UserQuote("Haley Sessions", "No road is long with good company. - Turkish Proverb"), /*A quote that should be cherished well as our bonds are important to continue on with more vigor - Brandon Mam*/
           new UserQuote("Paola Gonzalez", "The roots of education are bitter, but the fruit is sweet. - Aristotle"),
           new UserQuote("Dylan Zuniga", "All the love as always. H - Harry Styles"),
           new UserQuote("Kendall Wix", "At the end of this day, one shall stand, one shall fall!. O - Optimus Prime"),
           new UserQuote("Joseph Mitchell", "Education is a weapon, whose effect depends on who holds it in his hands and whom it is aimed. - Joseph Stalin"), /*This quote from how my perception of it is, seems the explain that knowledge is valuable and if you know your audience for it, then you'll be successful - Brandon Mam*/
           new UserQuote("Preston Rockholt", "I am the wisest man alive, for I know one thing, and that is that I know nothing. - [attributed to] Socrates"),
	       new UserQuote("Jonathon Huskey", "The path of least resistance is the path of the loser. -H. G. Wells"), /* A good quote about how you must work hard to acheve things in life - Adam Seymour*/
           new UserQuote("Jennifer Baldwin", "I am no bird; and no net ensnares me; I am a free human being with an independent will. - Charlotte Bronte"),
	       new UserQuote("Jonny Westfall", "No one will ever get what they want, and that is beautiful. - They Might Be Giants"),
           new UserQuote("Joseph Flanagan", "'Do. Or do not. There is no try.' -Yoda"), // I love this quote//
           new UserQuote("Jennifer Baldwin", "I am no bird; and no net ensnares me; I am a free human being with an independent will. - Charlotte Bronte"),
           new UserQuote("Mayra Orlando", "Problems are not stop signs, they are guidelines.- Robert H. Schiuller"),
           new UserQuote("Forrest Wilkerson", "You miss 100% of the shots you never take- Wayne Gretzky"), /* I live by this quote everyday */
           new UserQuote("Hannah Sprinkle", "There are no happy endings, endings are the saddest part. So just give me a happy middle and a very happy start. -Shel Silverstein"),
           new UserQuote("Evy Kollstrand", "You never know until you know, you know"), /* This is so true */
           new UserQuote("Keivon Arooji", "Education is what remains after one has forgotten what one has learned in school. -Albert Einstein"),
           new UserQuote("Darius Samani", "If I had nine hours to chop down a tree, I’d spend the first six sharpening my axe.” – Abraham Lincoln"),
           new UserQuote("Samuel Hinkelman", "If you never stop learning you will never stop seeing the possibilities. -Bill Gates"), /* Brilliant quote! - Aliyah Day */
           new UserQuote("Tobias Gladden", "I? I am a monument to all your sins. - The Gravemind"),
           new UserQuote("Samuel Hinkelman", "If you never stop learning you will never stop seeing the possibilities. -Bill Gates"),
           new UserQuote("Aliyah Day", "We delight in the beauty of the butterfly, but rarely admit the changes it has gone through to achieve that beauty. -Maya Angelou"),
           new UserQuote("Perry Courter", "Hell of a thing killing a man, you take away all he has, and everything he is ever gunna be - Clint Eastwood" ), /* A clasic quote from a clasic man - Adam Seymour */
           new UserQuote("Thomas Robertson", "I come to trade and to learn. - Barnabas Sackett"),
           new UserQuote("This is a Test", "Something witty is supposed to go here = Me"), /* This is a funny quote. Great Job! */
	       new UserQuote("Adam Seymour", "Lift itself is only a vision, a dream. nothing exists except empty space, and you. And you are but a thought - Mark Twain Mysterious stranger"),
           new UserQuote("Teresa Widmer", "Terry, you of all people should know, in your hotel, there's always someone watching. -Tess Ocean"),
           new UserQuote("Jabril Washington", "The more things change, the more they stay the same. -General shepard"),
	       new UserQuote("Karen Lopez", "It does not matter how slowly you go so long as you do not stop. - Confucius"),
           new UserQuote("Sarar Ayache", "The axe forgets, but the tree remembers. - Zimbabwean proverb?"),
           new UserQuote("Nick Suarez", "You drown not by falling into a river, but by staying submerged in it. - Paulo Coelho"),
           new UserQuote("Daniel Arthur", "Without music, life would be a mistake. - Friedrich Nietzsche"), //I love me some music
           new UserQuote("Thom Y", "Never give up. Today is hard, tomorrow will be worse, but the day after tomorrow will be sunshine. - Jack Ma"),
           // add the next user here using the formula above, don't forget the comma to separate the items in the initialization list.
           // IMPORTANT: If there is a conflict, you MUST fix it, compile to make sure
           // your program compiles and runs locally, then push to the git repository on GitHub.
        };

        // Do not modify below this line
        foreach (UserQuote item in userQuotes)
        {
            Console.WriteLine("My name is {0} and my favorite quote is: '{1}'", item.Name, item.Quote);
        }
        Console.WriteLine("\n");
    }
}
