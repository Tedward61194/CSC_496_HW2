using System;

namespace HW2
{
	public class Suit {

		static Suit CLUBS;
		static Suit DIAMONDS;
		static Suit HEARTS;
		static Suit SPADES;
		static Suit VALUES;

		private string name;
		private string symbol;

		public Suit (int value, string symbol, string name) {
			this.VALUES = value;
			this.symbol = symbol;
			this.name = name;

		}

		public bool CompareTo(Suit OtherSuitObject) {
			if (this.GetName () == OtherSuitObject.GetName ()) {
				return true;
			} else {
				return false;
			}
		}

		public int GetValue() {
			return this.VALUES;
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