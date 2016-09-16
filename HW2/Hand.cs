/*
 * Create an abstract Hand superclass that will represent the basic functionality for a hand of cards.
 * Extensions of this class will provide the definition of what constitutes a hand for that game
 * and how hands are compared to one another. Implement the following methods:
 * void AddCard(Card): adds a card to this hand
 * abstract int CompareTo(Hand OtherHandObject): compares two hands
 * bool ContainsCard(Card): returns true if the card is in this hand, false otherwise
 * void DiscardHand(): throws away all cards in the hand, leaving an empty hand
 * int FindCard(Card): searches the hand for the first occurence of hte specified card and returns the index
 * Card GetCardAtIndex(int): obtains the card stored at the specified location in the hand
 * int GetNumberOfCards(): returns the number of cards in the hand
 * bool IsEmpty(): returns true if the hand is empty, false otherwise
 * Card RemoveCard(Card): removes the first occurence of the specified card from this hand
 * Card RemoveCard(int): removes the card at the specified index posiont from this hand
 * abstract int EvaluateHand(): evaluates the hand, returns an integer corresponding to the rating of the hand
 * string ToString(): a description of this hand, which includes all cards in the hand
 */

using System;

namespace HW2 {

	public abstract class Hand {

		public Hand () {
		}

		void AddCard(Card) {
		}

		abstract int CompareTo(Hand OtherHandObject) {
		}

		bool ContainsCard(Card) {
		}

		void DiscardHand() {
		}

		int FindCard(Card) {
		}

		Card GetCardAtIndex(int) {
		}

		int GetNumberOfCards() {
		}

		bool IsEmpty() {
		}

		Card RemoveCard(Card) {
		}

		Card RemoveCard(int) {
		}

		abstract int EvaluateHand() {
		}

		string ToString(){
		}
	}
}

