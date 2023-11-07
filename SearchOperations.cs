using System.Text;

public class SearchOperations
{
    //arr[] = {2, 5, 8, 12, 16, 23, 38, 56, 72, 91}, and the target = 23.
    public int BinarySearch(int[] arrNums, int key)
    {
        var low=0;
        var high=arrNums.Length-1;
        int mid = (high-low)/2;
        
        while(low<=high){
            mid = low+(high-low)/2;
            if(key==arrNums[mid]) return mid;
            else if(key<arrNums[mid])
                high=mid-1;
            else if(key>arrNums[mid])
                low=mid+1;
        }
        return -1;
    }

}