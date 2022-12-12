using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonProblem
{
    public class Playrs
    {
        Queue<Cards> cardsQue;
        int[][] playerCards;

        public Playrs()
        {
            cardsQue = new Queue<Cards>();
            int[,] playerCards = new int[4, 13];
        }

        public void addCard(int suit, int rank)
        {
            playerCards[suit][rank] = 1;
        }

        public Cards getCard()
        {
            return cardsQue.Dequeue();
        }


        public void enqueueCards()
        {
            for (int suit = 0; suit < 4; suit++)
            {
                for (int rank = 0; rank < 13; rank++)
                {
                    if (playerCards[suit][rank] == 1)
                    {
                        cardsQue.Enqueue(new Cards(suit, rank));
                    }
                }
            }
        }
    }
}
