namespace LexicalAnalyzerApp.Classes
{
    public class LexicalState41 : LexicalStateBase
    {
        #region constructors
        public LexicalState41(LexicalAnalyzer lexicalAnalyzer) : base(lexicalAnalyzer)
        {

        }
        #endregion

        #region public methods
        public override void getNextState(char symbol)
        {
            if ((symbol >= 'a' && symbol <= 'z') || (symbol >= '0' && symbol <= '9'))
                return;

            _lexicalAnalyzer.changeState(new LexicalStateInvalid(_lexicalAnalyzer));
        }
        #endregion
    }
}