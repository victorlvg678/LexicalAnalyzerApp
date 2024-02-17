namespace LexicalAnalyzerApp.Classes
{
    public class LexicalState0 : LexicalStateBase
    {
        #region constructors
        public LexicalState0(LexicalAnalyzer lexicalAnalyzer) : base(lexicalAnalyzer)
        {

        }
        #endregion

        #region public methods
        public override void getNextState(char symbol)
        {
            if (symbol >= '0' && symbol <= '9')
            {
                _lexicalAnalyzer.changeState(new LexicalState1(_lexicalAnalyzer));
                return;
            }

            if (symbol == '+' || symbol == '-')
            {
                _lexicalAnalyzer.changeState(new LexicalState4(_lexicalAnalyzer));
                return;
            }

            if (symbol == '*' || symbol == '/')
            {
                _lexicalAnalyzer.changeState(new LexicalState5(_lexicalAnalyzer));
                return;
            }

            if (symbol == '=')
            {
                _lexicalAnalyzer.changeState(new LexicalState6(_lexicalAnalyzer));
                return;
            }

            if (symbol == '!')
            {
                _lexicalAnalyzer.changeState(new LexicalState7(_lexicalAnalyzer));
                return;
            }

            if (symbol == '{')
            {
                _lexicalAnalyzer.changeState(new LexicalState8(_lexicalAnalyzer));
                return;
            }

            if (symbol == ';')
            {
                _lexicalAnalyzer.changeState(new LexicalState9(_lexicalAnalyzer));
                return;
            }

            if (symbol == '(')
            {
                _lexicalAnalyzer.changeState(new LexicalState10(_lexicalAnalyzer));
                return;
            }

            if (symbol == '&')
            {
                _lexicalAnalyzer.changeState(new LexicalState11(_lexicalAnalyzer));
                return;
            }

            if (symbol == '|')
            {
                _lexicalAnalyzer.changeState(new LexicalState13(_lexicalAnalyzer));
                return;
            }

            if (symbol == '<' || symbol == '>')
            {
                _lexicalAnalyzer.changeState(new LexicalState16(_lexicalAnalyzer));
                return;
            }

            if (symbol == 'i')
            {
                _lexicalAnalyzer.changeState(new LexicalState17(_lexicalAnalyzer));
                return;
            }

            if (symbol == 'w')
            {
                _lexicalAnalyzer.changeState(new LexicalState21(_lexicalAnalyzer));
                return;
            }

            if (symbol == 'r')
            {
                _lexicalAnalyzer.changeState(new LexicalState26(_lexicalAnalyzer));
                return;
            }

            if (symbol == 'e')
            {
                _lexicalAnalyzer.changeState(new LexicalState32(_lexicalAnalyzer));
                return;
            }

            if (symbol == 'f')
            {
                _lexicalAnalyzer.changeState(new LexicalState36(_lexicalAnalyzer));
                return;
            }

            if ((symbol >= 'a' && symbol <= 'd') || (symbol >= 'g' && symbol <= 'h') || (symbol >= 'j' && symbol <= 'q') || (symbol >= 's' && symbol <= 'v') || (symbol >= 'x' && symbol <= 'z'))
            {
                _lexicalAnalyzer.changeState(new LexicalState41(_lexicalAnalyzer));
                return;
            }

            if (symbol == '\"')
            {
                _lexicalAnalyzer.changeState(new LexicalState42(_lexicalAnalyzer));
                return;
            }

            if (symbol == ',')
            {
                _lexicalAnalyzer.changeState(new LexicalState45(_lexicalAnalyzer));
                return;
            }

            if (symbol == ')')
            {
                _lexicalAnalyzer.changeState(new LexicalState46(_lexicalAnalyzer));
                return;
            }

            if (symbol == '}')
            {
                _lexicalAnalyzer.changeState(new LexicalState47(_lexicalAnalyzer));
                return;
            }

            _lexicalAnalyzer.changeState(new LexicalStateInvalid(_lexicalAnalyzer));
        }
        #endregion
    }
}