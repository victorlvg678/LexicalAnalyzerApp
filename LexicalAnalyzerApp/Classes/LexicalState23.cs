namespace LexicalAnalyzerApp.Classes
{
    public class LexicalState23 : LexicalStateBase
    {
        #region constructors
        public LexicalState23(LexicalAnalyzer lexicalAnalyzer) : base(lexicalAnalyzer)
        {

        }
        #endregion

        #region public methods
        public override void getNextState(char symbol)
        {
            if (symbol == 'l')
            {
                _lexicalAnalyzer.changeState(new LexicalState24(_lexicalAnalyzer));
                return;
            }

            if ((symbol >= 'a' && symbol <= 'k') || (symbol >= 'm' && symbol <= 'z') || (symbol >= '0' && symbol <= '9'))
            {
                _lexicalAnalyzer.changeState(new LexicalState41(_lexicalAnalyzer));
                return;
            }

            _lexicalAnalyzer.changeState(new LexicalStateInvalid(_lexicalAnalyzer));
        }
        #endregion
    }
}