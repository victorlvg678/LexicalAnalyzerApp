namespace LexicalAnalyzerApp.Classes
{
    public class LexicalState42 : LexicalStateBase
    {
        #region constructors
        public LexicalState42(LexicalAnalyzer lexicalAnalyzer) : base(lexicalAnalyzer)
        {

        }
        #endregion

        #region public methods
        public override void getNextState(char symbol)
        {
            if (symbol != '\"')
                return;
            
            _lexicalAnalyzer.changeState(new LexicalState43(_lexicalAnalyzer));
        }
        #endregion
    }
}