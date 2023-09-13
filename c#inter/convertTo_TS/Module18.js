var Module18 = /** @class */ (function () {
    function Module18() {
    }
    /* dynamic */ Module18.prototype.operation1 = function () {
        console.log(this.object1);
        console.log(object2);
        console.log(this.object3);
        console.log(object4);
    };
    Module18.prototype.operation3 = function (/* Module18 this */ operand) {
        console.log(this.object1 + operand);
        console.log(object2);
        console.log(this.object3 + operand);
        console.log(object4);
    };
    Module18.Main = function (args) {
        var RecordObject1 = new Module18();
        RecordObject1.object1 = 1;
        RecordObject1.object3 = 3;
        RecordObject1.operation1(); // operation1 (RecordObject1);
        RecordObject1.operation3(10); // operation3 (RecordObject1, 10);
        var RecordObject2 = new Module18();
        RecordObject2.object1 = 5;
        RecordObject2.object3 = 7;
        RecordObject2.operation1(); // operation1 (RecordObject2);
        RecordObject2.operation3(10); // operation3 (RecordObject2, 10);
    }; // usai alokasi memori, assign value; RecordObject1 := Module18();
    Module18.object2 = 2;
    Module18.object4 = 4;
    return Module18;
}());
