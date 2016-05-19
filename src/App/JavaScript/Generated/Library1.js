"use strict";

Object.defineProperty(exports, "__esModule", {
  value: true
});
exports.X = exports.buttonClicked = exports.obsU = exports.untypedProjection = exports.untypedObservable = exports.obsZ = exports.numNames = exports.names = exports.Player = exports.kiss = exports.obsY = exports.unsafeObsX = exports.obsX = exports.observableNumber = exports.observableString = exports.timer = exports.counter = undefined;

var _Environment = require("FuseJS/Environment");

var _Environment2 = _interopRequireDefault(_Environment);

var _Lifecycle = require("FuseJS/Lifecycle");

var _Lifecycle2 = _interopRequireDefault(_Lifecycle);

var _InterApp = require("FuseJS/InterApp");

var _InterApp2 = _interopRequireDefault(_InterApp);

var _Observable = require("./Observable");

var _Timer = require("FuseJS/Timer");

var _Timer2 = _interopRequireDefault(_Timer);

var _fableCore = require("fable-core");

var _Observable2 = require("FuseJS/Observable");

var _Observable3 = _interopRequireDefault(_Observable2);

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

_Environment2.default.iOS ? console.log("Running on iOS") : null;
_Environment2.default.android ? console.log("Running on Android") : null;
_Environment2.default.preview ? console.log("Running in preview mode") : null;
_Environment2.default.mobile ? console.log("Running on iOS or Android") : null;
_Environment2.default.desktop ? console.log("Running on desktop") : null;

_Lifecycle2.default.onEnteringForeground = function (unitVar0) {
  console.log("Entering foreground, new style");
};

_Lifecycle2.default.onEnteringBackground = function (unitVar0) {
  console.log("Entering background, new style");
};

_InterApp2.default.onReceivedUri = function (str) {
  console.log("Received: " + str);
};

var counter = exports.counter = (0, _Observable.createWith)(0);

var timer = exports.timer = _Timer2.default.create(function (unitVar0) {
  counter.value = counter.value + 1;
}, 1000, true);

counter.addSubscriber(function (c) {
  console.log(function () {
    var clo1;
    return clo1 = _fableCore.String.fsFormat("Counter changed: %d")(function (x) {
      return x;
    }), function (arg10) {
      return clo1(arg10);
    };
  }()(c.value));
  c.value >= 10 ? _Timer2.default.delete(timer) : null;
});
var observableString = exports.observableString = (0, _Observable.createWith)("Testing");
var observableNumber = exports.observableNumber = observableString.map(function (s) {
  return s.length;
});
var obsX = exports.obsX = (0, _Observable.createWith)("Heia!");
var unsafeObsX = exports.unsafeObsX = (0, _Observable.createUnsafeWith)("Hoheya!");
unsafeObsX.value = 15;
var obsY = exports.obsY = (0, _Observable.createWith)(89);
var kiss = exports.kiss = (0, _Observable3.default)("Paul", "Ace");

var Player = exports.Player = function Player($arg0, $arg1) {
  _classCallCheck(this, Player);

  this.name = $arg0;
  this.age = $arg1;
};

var names = exports.names = (0, _Observable.createTyped)();
names.replaceAll([new Player("John", 71), new Player("Ringo", 45), new Player("Paul", 69)]);
var numNames = exports.numNames = names.count(function (n) {
  return n.name.length > 4;
});
var obsZ = exports.obsZ = obsY.map(function (old) {
  return old + 1;
});
var untypedObservable = exports.untypedObservable = (0, _Observable.create)();
untypedObservable.value = "WOHEY!";
var untypedProjection = exports.untypedProjection = untypedObservable.map(function (o) {
  var str;
  return typeof o === "string" ? (str = o, str + " matched") : function () {
    throw "Didn't expect that, no sir";
  }();
});
var obsU = exports.obsU = obsZ.map(function (p, idx) {
  return p + (idx + 1);
});

var buttonClicked = exports.buttonClicked = function (args) {
  return console.log(JSON.stringify(args));
};

console.log(obsX.value);
console.log(obsY.value);
var X = exports.X = "Hello again from F#!";