using System;

class MainClass {
  public static void Main (string[] args) {
    //Console.WriteLine ("Hello World");
    int pos_found = 0;
    int peak_tmp;
	
    Console.WriteLine("Enter array size:");
    int size = Convert.ToInt32(Console.ReadLine());
	
    int [] arr = new int[size];
	
    Console.WriteLine("Enter {0} number of array contents", size);
    for(int i = 0; i < size; i++){
      arr[i] = Convert.ToInt32(Console.ReadLine());
    }
	
    float mid_tmp = size / 2;
    int mid = Convert.ToInt32(Math.Floor(mid_tmp));
    //Console.WriteLine(mid);
    if(arr[mid -1] < arr[mid]){
      peak_tmp = arr[mid + 1];
      
      for(int i = mid + 1; i < size; i++){
        if(arr[i] > peak_tmp){
          peak_tmp = arr[i];
          pos_found = i;
        }
      }
    }
    else if(arr[mid -1] > arr[mid]){
      peak_tmp = arr[mid - 1];
      for(int i = 0; i <= mid - 1; i++){
        if(arr[i] > peak_tmp){
          peak_tmp = arr[i];
          pos_found = i;
        }
      }
    }
    else{
      peak_tmp = arr[mid];
      pos_found = mid;
    }
    Console.WriteLine("The peak in the given arr is {0} at {1} position", peak_tmp, pos_found + 1);
  }

  

}
