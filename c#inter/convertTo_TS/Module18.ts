
class Module18
{
    object1: number; // Dynamic
    static object2: number = 2;
    object3: number; // Dynamic
    static object4: number = 4;

   /* dynamic */ operation1() :void
    {
      console.log(this.object1);
      console.log(object2);
      console.log(this.object3);
      console.log(object4);
    }

    /* dynamic */ operation3( /* Module18 this */ operand: number): void
    {
      console.log(this.object1 + operand);
      console.log(object2);
      console.log(this.object3 + operand);
      console.log(object4);
    }

   static Main(args: string[]) :void
    { // Module18 RecordObject1; Allocate (RecordObject1);
      const RecordObject1 : Module18  = new Module18();
      RecordObject1.object1 = 1;
      RecordObject1.object3 = 3;
      RecordObject1.operation1(); // operation1 (RecordObject1);
      RecordObject1.operation3(10); // operation3 (RecordObject1, 10);
      const RecordObject2 : Module18 = new Module18();
      RecordObject2.object1 = 5;
      RecordObject2.object3 = 7;
      RecordObject2.operation1(); // operation1 (RecordObject2);
      RecordObject2.operation3(10); // operation3 (RecordObject2, 10);
    } // usai alokasi memori, assign value; RecordObject1 := Module18();
}