/*
 * Create a Deck class, which represents a "deck" of playing cards. In order to have maximum flexibility, this class does not implement a standard deck
 * of playing cards. Rather, it only provides the functionality of a deck of cards. When the Deck object is instantiated elsewhere, it is then populated
 * with the set of plaing cards appropriate for he card game being implemented. This allows for proper implementation of card games such as
 * pinochle (a 48- card deck containgin only aces, nines, tens, jacks, queens, and kings in all four suits) or Blackjack (where si standard decks
 * are used for a game). There will be only one constructor: Deck(), which creates an empty deck of cards. Also implement the following methods:
 * void AddCard(card): adds a card to the deck
 * Card DealOne() deal one card from the deck
 * int GetCardsRemaining(): returns the number of cards remaining in the current deck
 * int GetDeckSize(): returns the size of a full deck of cards
 * bool IsEmpty(): returns true if the deck is empty
 * void Shuffle(): shuffles the deck of cards that are present in the deck
 * void RestoreDeck(): resets the deck back to a full deck, by replacing any cards taht were dealt out
 */

using System;

namespace HW2 {
	public class Deck {

		int size;
		int cardsRemaining;
		bool isEmpty;

		public Deck () {
			int size = 0;
			int cardsRemaining = 0;
			bool isEmpty = true;
		}

		public void AddCard(Card card) {
		}

		public Card DealOne() {
		}

		public int GetCardsRemaining() {
		}

		public int GetDeckSize() {
		}

		public bool IsEmpty() {
		}

		public void Shuffle() {
		}

		public void RestoreDeck() {
		}
	}
}

