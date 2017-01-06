using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class ChartObject
{
    #region Attributes

    protected string _title;
    protected int    _yparms;
    protected string _query;
    protected string _chartType;
    protected string _xVarLegend;
    protected string _xVarName;
    protected string _xVarColor;
    protected string _xVarFormat;
    protected string _y1VarLegend;
    protected string _y1VarName;
    protected string _y1VarColor;
    protected string _y1VarFormat;
    protected string _y2VarLegend;
    protected string _y2VarName;
    protected string _y2VarColor;
    protected string _y2VarFormat;
    protected string _end;
    protected string _comment;

    #endregion

    #region Constructors
    public ChartObject()
    { }
    public ChartObject(string record)
    {   //  separate large block into individual strings
        string slctClauseX1 = "DocType";
        string frmClauseX1 = "tableName";
        string wrClasueX1 = "docNum";
        string wrClauseValueX1 = "301";
        string slctClauseY1 = "DocType";
        string frmClauseY1 = "tableName";
        string wrClasueY1 = "docNum";
        string wrClauseValueY1 = "301";
        string slctClauseY2 = "DocType";
        string frmClauseY2 = "tableName";
        string wrClasueY2 = "docNum";
        string wrClauseValueY2 = "301";
         _yparms = 1;
        string[] segments = record.Split('\n');
        for (int i = 0; i < segments.Length; i++)
        {   //  Compress the Strings and separate the fields      CC
            string segment = Compress(segments[i]);

            //  **2  Chart  Project_Actual_Cost_By_Month  Bar  yparams = 1
            //   0     1            2                      3      4    5 6
            string[] fields = segment.Split();
            switch (fields[0])
            { //   respond to the first field                       DD
                case "Chart":
                case "chart":

                    _title = fields[1];
                    if (fields.Length > 1) _chartType = fields[2];
                    break;
                case "Data":
                case "data":

                    switch (fields[1])
                    { //   respond to the first field                   EE switch for field [1]
                        case "X1Values":
                        case "x1values":
                            // this string array block wil get the values of first x segment
                            // Data  X1Values  =  DocType  from  ProjectsActualByMonth  where  DocNum  =  301 
                            //   0     1       2      3      4        5                  6       7     8   9
                            slctClauseX1 = fields[3];    //x1SubString[6].Trim(); //S_ATTR1
                            frmClauseX1 = fields[5];     // x1SubString[10].Trim();
                            wrClasueX1 = fields[7];      //DocNum
                            wrClauseValueX1 = fields[9];
                            break;
                        case "Y1Values":
                        case "y1values":
                            // this string array block wil get the values of first y segment
                            // Data  Y1Values  =   Cumcost  from  ProjectsActualByMonth  where  DocNum  =  301 
                            //   0     1       2      3      4          5                  6      7     8   9
                            slctClauseY1 = fields[3];  //S_ATTR2
                            frmClauseY1 = fields[5];
                            wrClasueY1 = fields[7];
                            wrClauseValueY1 = fields[9];
                            break;

                        case "Y2Values":
                        case "y2values":
                            // this string array block wil get the values of second y segment
                            // Data  Y2Values  =   Estcost  from  ProjectsEstByMonth  where  DocNum  =  301 
                            //   0     1       2      3      4          5               6      7     8   9
                            slctClauseY2 = fields[3];
                            frmClauseY2 = fields[5];
                            wrClasueY2 = fields[7];
                            wrClauseValueY2 = fields[9];
                            break;  //   from case  Y2Values
                    }                                                                        //  end of EE switch for field[1]                                  
                    break;   //  from case "Data"

                case "Params":
                case "params":

                    switch (fields[1])
                    { //   respond to the first field                                       EE  switch fields
                        case "X1Values":
                        case "x1values":
                            //  Params  X1values  Month  docType  Black  Text
                            //     0       1        2      3        4      5
                            _xVarLegend = fields[2];   //  legend text MOnth
                            _xVarName = fields[3];   //   name = doctype
                            _xVarColor = fields[4];   //   color
                            _xVarFormat = fields[5];   //   format
                            break;
                        case "Y1Values":
                        case "y1values":
                            //  Params  Y1values  Estimated  EstCost  Red  Text
                            //     0       1          2        3        4    5
                            _y1VarLegend = fields[2];   // legend text Estimated
                            _y1VarName = fields[3];   // name is string format of column name
                            _y1VarColor = fields[4];   // color
                            _y1VarFormat = fields[5];   // format
                            break;
                        case "Y2Values":
                        case "y2values":
                            //  Params  Y2values  actual  ActualCost  Blue  Text
                            //     0       1         2        3        4    5
                            _y2VarLegend = fields[2];   // legend text Estimated
                            _y2VarName = fields[3];   // name is string format of column name
                            _y2VarColor = fields[4];   // color
                            _y2VarFormat = fields[5];   // format
                            _yparms = 2; // as we have y2 value
                            break;
                    }  //  from switch fields[1]                                        EE from switch fields[1]

                    break;   //  from case Params

                    //       DD  from  switch fields[0]
            }                                                //   end of for loop  ??
                    if (_yparms == 1)
                        _query = "SELECT [" + slctClauseX1 + "] as [Xvar], [" + slctClauseY1 + "] AS [Y1Var] FROM [" + frmClauseY1 + "]";
                    else
                        _query = "SELECT [e." + slctClauseX1 + "] as [Xvar], [e." + slctClauseY1 + "] AS [Y1Var], [a." + slctClauseY2 + "] AS [Y2Var] FROM [" + frmClauseY1 + "] AS [e] INNER JOIN [" + frmClauseY2 + "] AS [a] ON e.[" + slctClauseX1 + "] = a.[" + slctClauseX1 + "] WHERE e.[" + wrClasueX1 + "] = " + wrClauseValueX1;
            
        }
    }
    
    #endregion
    #region Properties
    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }
    public string Query
    {
        get { return _query; }
        set { _query = value; }
    }
    public string ChartType
    {
        get { return _chartType; }
        set { _chartType = value; }
    }
    public string XVarLegend
    {
        get { return _xVarLegend; }
        set { _xVarLegend = value; }
    }
    public string Y1VarLegend
    {
        get { return _y1VarLegend; }
        set { _y1VarLegend = value; }
    }
    public string Y2VarLegend
    {
        get { return _y2VarLegend; }
        set { _y2VarLegend = value; }
    }
    public string XVarName
    {
        get { return _xVarName; }
        set { _xVarName = value; }
    }
    public string Y1VarName
    {
        get { return _y1VarName; }
        set { _y1VarName = value; }
    }
    public string Y2VarName
    {
        get { return _y2VarName; }
        set { _y2VarName = value; }
    }

    public string XVarColor
    {
        get { return _xVarColor; }
        set { _xVarColor = value; }
    }
    public string Y1VarColor
    {
        get { return _y1VarColor; }
        set { _y1VarColor = value; }
    }
    public string Y2VarColor
    {
        get { return _y2VarColor; }
        set { _y2VarColor = value; }
    }

    public string XVarFormat
    {
        get { return _xVarFormat; }
        set { _xVarFormat = value; }
    }
    public string Y1VarFormat
    {
        get { return _y1VarFormat; }
        set { _y1VarFormat = value; }
    }
    public string Y2VarFormat
    {
        get { return _y2VarFormat; }
        set { _y2VarFormat = value; }
    }
    #endregion

    protected virtual string Compress(string targetStr)
    {
        //   removes adjacent blanks from a string and returns a “clean” string

        string cleanString = string.Join(" ", targetStr.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        return cleanString.Trim();
    }
    public override string ToString()
    {
              return String.Format("{0} \n {1}  {2}    \n  {3}  {4}  ",
                                _query, _yparms, _title, XVarName, Y1VarName);
   } 
    
}
