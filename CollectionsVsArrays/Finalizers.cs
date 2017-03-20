namespace CollectionsVsArrays
{
    public class Finalizers
    {
        //Finalizer is the opposite of a constructor.
        //Last opportunity to work with an object before it is removed from memory
        //Name begins with ~
        //Should only be used when necessary.  You are slowing down the reclaiming of the mmeory.
        //You cannot predict what order the finalizers will be called.
    }
}