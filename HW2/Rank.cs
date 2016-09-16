/*
 * Create a Rank class, which will specify the rank values for a standard deck of cards. Ranks are established in the following ascending order 2,3,4...K,A.
 * (This class could be extended for implementation of games with specialty decks.)
 * The class should define the following static fields: TWO, THREE, FOUR...KING, ACE
 * The class should also define a static field List<Rank: VALUES, which lists all rank values in the deck. The following methods should be defined:
 * int Compareto(Rank OtherrankObject): returns 0 if the ranks are the same, -1 if this object has a lower rank than the otehr object, 1 if this object has a higher rank than the other object.
 * string GetSymbol(): the symbol associated with the rank (e.g. Q)
 * string GetName():the name associated with the rank (e.g. Queen)
 * string ToString(): the name associated with the rank
 */

using System;

namespace HW2 {
	public class Rank {
		static Rank TWO;
		static Rank THREE;
		static Rank FOUR;
		static Rank FIVE;
		static Rank SIZ;
		static Rank SEVEN;
		static Rank EIGHT;
		static Rank NINE;
		static Rank TEN;
		static Rank JACK;
		static Rank QUEEN;
		static Rank King;
		static Rank Ace;

		private int value;
		private string symbol;
		private string name;

		static List<Rank>;

		public Rank (int value, string symbol, string name) {
			this.value = value;
			this.symbol = symbol;
			this.name = name;

		}

		public int Compareto(Rank OtherrankObject) {
			if (this.GetValue () < OtherrankObject.GetValue ()) {
				return -1;
			}
			if (this.GetValue () == OtherrankObject.GetValue ()) {
				return 0;
			}
			if (tihs.GetValue () > OtherrankObject.GetValue ()) {
				return 1;
			}
		}

		public int GetValue() {
			return this.value;
		}

		public string GetSymbol() {
			return this.symbol;
		}

		public string GetName() {
			return this.name;
		}

		public string ToString() {
			return this.name;
		}
	}
}

