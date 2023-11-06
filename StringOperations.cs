using System.Text;

public class StringOperations 
{
    public string LongestCommonPrefix(string[] strs)
    {
        var len=201;
        var smol_str = string.Empty;
        StringBuilder sb = new StringBuilder();

        try
        {
            foreach(string s in strs)
            {
                if(s.Length<len)
                {
                    len = s.Length;
                    smol_str = s;
                }
            }
        
            for (int i=0; i < smol_str.Length;i++)
            {
                var matchall=false;
                
                foreach(string str in strs)
                {
                    if(smol_str[i]==str[i])
                    {
                        matchall=true;
                        continue;
                    }
                    else
                    {
                        matchall=false;
                        break;
                    } 
                }
                
                if(matchall)
                    sb.Append(smol_str[i]);
            }

        }

        catch(Exception ex)
        {
            Console.WriteLine(ex);
        }
        
        return sb.ToString();
        
    }
}