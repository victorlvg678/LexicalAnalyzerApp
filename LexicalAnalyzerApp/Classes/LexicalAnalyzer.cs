using System.Windows.Forms;

namespace LexicalAnalyzerApp.Classes
{
    public class LexicalAnalyzer
    {
        #region private members
        private LexicalStateBase _state;
        private string _input;
        private int _currentChar;
        #endregion

        #region constructors
        public LexicalAnalyzer()
        {
            _state = new LexicalState0(this);
            _input = string.Empty;
            _currentChar = 0;
        }

        public LexicalAnalyzer(string input)
        {
            _state = new LexicalState0(this);
            _input = input;
            _currentChar = 0;
        }

        public LexicalAnalyzer(string input, int state, int currentChar)
        {
            _input = input;
            _currentChar = currentChar;

            switch (state)
            {
                case 0: { _state = new LexicalState0(this); break; }
                case 1: { _state = new LexicalState1(this); break; }
                case 2: { _state = new LexicalState2(this); break; }
                case 3: { _state = new LexicalState3(this); break; }
                case 4: { _state = new LexicalState4(this); break; }
                case 5: { _state = new LexicalState5(this); break; }
                case 6: { _state = new LexicalState6(this); break; }
                case 7: { _state = new LexicalState7(this); break; }
                case 8: { _state = new LexicalState8(this); break; }
                case 9: { _state = new LexicalState9(this); break; }
                case 10: { _state = new LexicalState10(this); break; }
                case 11: { _state = new LexicalState11(this); break; }
                case 12: { _state = new LexicalState12(this); break; }
                case 13: { _state = new LexicalState13(this); break; }
                case 14: { _state = new LexicalState14(this); break; }
                case 15: { _state = new LexicalState15(this); break; }
                case 16: { _state = new LexicalState16(this); break; }
                case 17: { _state = new LexicalState17(this); break; }
                case 18: { _state = new LexicalState18(this); break; }
                case 19: { _state = new LexicalState19(this); break; }
                case 20: { _state = new LexicalState20(this); break; }
                case 21: { _state = new LexicalState21(this); break; }
                case 22: { _state = new LexicalState22(this); break; }
                case 23: { _state = new LexicalState23(this); break; }
                case 24: { _state = new LexicalState24(this); break; }
                case 25: { _state = new LexicalState25(this); break; }
                case 26: { _state = new LexicalState26(this); break; }
                case 27: { _state = new LexicalState27(this); break; }
                case 28: { _state = new LexicalState28(this); break; }
                case 29: { _state = new LexicalState29(this); break; }
                case 30: { _state = new LexicalState30(this); break; }
                case 31: { _state = new LexicalState31(this); break; }
                case 32: { _state = new LexicalState32(this); break; }
                case 33: { _state = new LexicalState33(this); break; }
                case 34: { _state = new LexicalState34(this); break; }
                case 35: { _state = new LexicalState35(this); break; }
                case 36: { _state = new LexicalState36(this); break; }
                case 37: { _state = new LexicalState37(this); break; }
                case 38: { _state = new LexicalState38(this); break; }
                case 39: { _state = new LexicalState39(this); break; }
                case 40: { _state = new LexicalState40(this); break; }
                case 41: { _state = new LexicalState41(this); break; }
                default: { _state = new LexicalStateInvalid(this); break; }
            }
        }
        #endregion

        #region public methods
        public void getNextState()
        {
            if (string.IsNullOrWhiteSpace(_input))
                return;

            if (_currentChar < 0 || _currentChar > (_input.Length - 1))
                return;

            _state.getNextState(_input[_currentChar]);
        }

        public void changeState(LexicalStateBase state)
        {
            _state = state;
            _currentChar++;
        }

        public LexicalStateBase getCurrentState() => _state;

        public int getTokenNumber() 
        {
            if (_state.GetType().Equals(typeof(LexicalState41))) return 0;
            if (_state.GetType().Equals(typeof(LexicalState1))) return 1;
            if (_state.GetType().Equals(typeof(LexicalState3))) return 2;
            if (_state.GetType().Equals(typeof(LexicalState43))) return 3;
            if (_state.GetType().Equals(typeof(LexicalState40)) || _state.GetType().Equals(typeof(LexicalState20))) return 4;
            if (_state.GetType().Equals(typeof(LexicalState4))) return 5;
            if (_state.GetType().Equals(typeof(LexicalState5))) return 6;
            if (_state.GetType().Equals(typeof(LexicalState16)) || _state.GetType().Equals(typeof(LexicalState44))) return 7;
            if (_state.GetType().Equals(typeof(LexicalState14))) return 8;
            if (_state.GetType().Equals(typeof(LexicalState12))) return 9;
            if (_state.GetType().Equals(typeof(LexicalState7))) return 10;
            if (_state.GetType().Equals(typeof(LexicalState15))) return 11;
            if (_state.GetType().Equals(typeof(LexicalState9))) return 12;
            if (_state.GetType().Equals(typeof(LexicalState45))) return 13;
            if (_state.GetType().Equals(typeof(LexicalState10))) return 14;
            if (_state.GetType().Equals(typeof(LexicalState46))) return 15;
            if (_state.GetType().Equals(typeof(LexicalState8))) return 16;
            if (_state.GetType().Equals(typeof(LexicalState47))) return 17;
            if (_state.GetType().Equals(typeof(LexicalState6))) return 18;
            if (_state.GetType().Equals(typeof(LexicalState18))) return 19;
            if (_state.GetType().Equals(typeof(LexicalState25))) return 20;
            if (_state.GetType().Equals(typeof(LexicalState31))) return 21;
            if (_state.GetType().Equals(typeof(LexicalState35))) return 22;

            return -1;
        }

        public int currentChar
        {
            set => _currentChar = (value >= 0) ? value : 0;

            get => _currentChar;
        }

        public int state
        {
            set
            {
                switch (value)
                {
                    case 0: { _state = new LexicalState0(this); break; }
                    case 1: { _state = new LexicalState1(this); break; }
                    case 2: { _state = new LexicalState2(this); break; }
                    case 3: { _state = new LexicalState3(this); break; }
                    case 4: { _state = new LexicalState4(this); break; }
                    case 5: { _state = new LexicalState5(this); break; }
                    case 6: { _state = new LexicalState6(this); break; }
                    case 7: { _state = new LexicalState7(this); break; }
                    case 8: { _state = new LexicalState8(this); break; }
                    case 9: { _state = new LexicalState9(this); break; }
                    case 10: { _state = new LexicalState10(this); break; }
                    case 11: { _state = new LexicalState11(this); break; }
                    case 12: { _state = new LexicalState12(this); break; }
                    case 13: { _state = new LexicalState13(this); break; }
                    case 14: { _state = new LexicalState14(this); break; }
                    case 15: { _state = new LexicalState15(this); break; }
                    case 16: { _state = new LexicalState16(this); break; }
                    case 17: { _state = new LexicalState17(this); break; }
                    case 18: { _state = new LexicalState18(this); break; }
                    case 19: { _state = new LexicalState19(this); break; }
                    case 20: { _state = new LexicalState20(this); break; }
                    case 21: { _state = new LexicalState21(this); break; }
                    case 22: { _state = new LexicalState22(this); break; }
                    case 23: { _state = new LexicalState23(this); break; }
                    case 24: { _state = new LexicalState24(this); break; }
                    case 25: { _state = new LexicalState25(this); break; }
                    case 26: { _state = new LexicalState26(this); break; }
                    case 27: { _state = new LexicalState27(this); break; }
                    case 28: { _state = new LexicalState28(this); break; }
                    case 29: { _state = new LexicalState29(this); break; }
                    case 30: { _state = new LexicalState30(this); break; }
                    case 31: { _state = new LexicalState31(this); break; }
                    case 32: { _state = new LexicalState32(this); break; }
                    case 33: { _state = new LexicalState33(this); break; }
                    case 34: { _state = new LexicalState34(this); break; }
                    case 35: { _state = new LexicalState35(this); break; }
                    case 36: { _state = new LexicalState36(this); break; }
                    case 37: { _state = new LexicalState37(this); break; }
                    case 38: { _state = new LexicalState38(this); break; }
                    case 39: { _state = new LexicalState39(this); break; }
                    case 40: { _state = new LexicalState40(this); break; }
                    case 41: { _state = new LexicalState41(this); break; }
                    default: { _state = new LexicalStateInvalid(this); break; }
                }
            }

            get
            {
                if (_state.GetType().Equals(typeof(LexicalState0))) return 0;
                if (_state.GetType().Equals(typeof(LexicalState1))) return 1;
                if (_state.GetType().Equals(typeof(LexicalState2))) return 2;
                if (_state.GetType().Equals(typeof(LexicalState3))) return 3;
                if (_state.GetType().Equals(typeof(LexicalState4))) return 4;
                if (_state.GetType().Equals(typeof(LexicalState5))) return 5;
                if (_state.GetType().Equals(typeof(LexicalState6))) return 6;
                if (_state.GetType().Equals(typeof(LexicalState7))) return 7;
                if (_state.GetType().Equals(typeof(LexicalState8))) return 8;
                if (_state.GetType().Equals(typeof(LexicalState9))) return 9;
                if (_state.GetType().Equals(typeof(LexicalState10))) return 10;
                if (_state.GetType().Equals(typeof(LexicalState11))) return 11;
                if (_state.GetType().Equals(typeof(LexicalState12))) return 12;
                if (_state.GetType().Equals(typeof(LexicalState13))) return 13;
                if (_state.GetType().Equals(typeof(LexicalState14))) return 14;
                if (_state.GetType().Equals(typeof(LexicalState15))) return 15;
                if (_state.GetType().Equals(typeof(LexicalState16))) return 16;
                if (_state.GetType().Equals(typeof(LexicalState17))) return 17;
                if (_state.GetType().Equals(typeof(LexicalState18))) return 18;
                if (_state.GetType().Equals(typeof(LexicalState19))) return 19;
                if (_state.GetType().Equals(typeof(LexicalState20))) return 20;
                if (_state.GetType().Equals(typeof(LexicalState21))) return 21;
                if (_state.GetType().Equals(typeof(LexicalState22))) return 22;
                if (_state.GetType().Equals(typeof(LexicalState23))) return 23;
                if (_state.GetType().Equals(typeof(LexicalState24))) return 24;
                if (_state.GetType().Equals(typeof(LexicalState25))) return 25;
                if (_state.GetType().Equals(typeof(LexicalState26))) return 26;
                if (_state.GetType().Equals(typeof(LexicalState27))) return 27;
                if (_state.GetType().Equals(typeof(LexicalState28))) return 28;
                if (_state.GetType().Equals(typeof(LexicalState29))) return 29;
                if (_state.GetType().Equals(typeof(LexicalState30))) return 30;
                if (_state.GetType().Equals(typeof(LexicalState31))) return 31;
                if (_state.GetType().Equals(typeof(LexicalState32))) return 32;
                if (_state.GetType().Equals(typeof(LexicalState33))) return 33;
                if (_state.GetType().Equals(typeof(LexicalState34))) return 34;
                if (_state.GetType().Equals(typeof(LexicalState35))) return 35;
                if (_state.GetType().Equals(typeof(LexicalState36))) return 36;
                if (_state.GetType().Equals(typeof(LexicalState37))) return 37;
                if (_state.GetType().Equals(typeof(LexicalState38))) return 38;
                if (_state.GetType().Equals(typeof(LexicalState39))) return 39;
                if (_state.GetType().Equals(typeof(LexicalState40))) return 40;
                if (_state.GetType().Equals(typeof(LexicalState41))) return 41;

                return 42;
            }
        }

        public string input
        {
            set => _input = !string.IsNullOrWhiteSpace(value) ? value : string.Empty;

            get => _input;
        }
        #endregion
    }
}