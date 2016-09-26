/* Create a Card class, which will represent of a single playing card. A card consists of a suit value (e.g. hearts, spades)
 * and a rank value (e.g. ace, 7, king). A card object is immutable; once instantiated, the values cannot change.
 * The class will have a constructor: Card(Suit, Rank). It will have the following methods:
 * 
 * 		int CompareTo(Card OtherCardObject): returns a 0 if the cards are the same, -1 if this card would be sorted lower
 * 		than the other card, 1 if this object would be sorted higher than the other card.
 *		Rank GetRank(): returns the rank of this card
 *		Suit GetSuit(): returns the suit of this card
 *		String ToString(): returns a description of this card
 *
 */

using System;

namespace HW2 {
	public class Card {

		Suit theSuit;
		Rank theRank;

		public Card (Suit s, Rank r) {
			this.theSuit = s;
			this.theRank = r;
		}

		int CompareTo(Card OtherCardObject) {
			if (this.GetRank ().GetValue () == OtherCardObject.GetRank ().GetValue ()) {
				return 0;
			} else if (this.GetRank ().GetValue () < OtherCardObject.GetRank ().GetValue ()) {
				return -1;
			} else if (this.GetRank ().GetValue () > OtherCardObject.GetRank ().GetValue ()) {
				return 1;
			}
		}

		Rank GetRank() {
			return this.theRank.GetName ();
		}

		Suit GetSuit() {
			return this.theSuit.GetName ();
		}

		String ToString() {
			String stringVal = GetRank ().GetName + GetSuit ().GetSymbol ();
			return stringVal;
		}
	}
}