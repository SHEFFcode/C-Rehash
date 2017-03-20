namespace CollectionsVsArrays
{
    public class GarbageCollection
    {
        //Why garbage collection? Memory management is a major concern for developers. Memory leaks: memory was allocated, but memory was never released.
        //GC can only work on managed memory objects, will not work for those.
        //GC does not happen immediately once an object is orphaned.
        //GC Occurs periodically based on available memory, current memory allocation and time since the last collection.
        //GC can occre from seconds to days
        //Not all orphaned objects are reclaimed during every collection
        //There are instances where helping GC along is necessary
        //You can force garbage collection by calling GC.Collect(); But don't do this for the most part.
        //GC vs Disposal - GC is fully automated, works well inside C#.
        //Disposal is a helper - some resourcerces require code to release them fastr. GC will eventually do this, if it had DBs, files etc connections open.
        //Disposal provides teardown code to release resources.
        //Disposed does nto mean memory is freed up, just that we have orphaned the object and GC will collect it.
        //Disposal uses an IDisposable interface, and has one method: void Dispose();
        //Either use Dispose method on the object, but we can also use the 'using' statement.  It automatically calls IDispose.
        //Whenever you are in doubt, dispose.
        //Connections, streams, delegates etc.




    }
}