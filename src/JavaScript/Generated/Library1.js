"use strict";

Object.defineProperty(exports, "__esModule", {
  value: true
});
exports.X = exports.buttonClicked = exports.plainObservable = exports.obsZ = exports.numNames = exports.names = exports.Player = exports.kiss = exports.obsY = exports.obsX = exports.observableNumber = exports.observableString = undefined;

var _Observable = require("FuseJS/Observable");

var _Observable2 = _interopRequireDefault(_Observable);

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

var observableString = exports.observableString = (0, _Observable2.default)("Testing");
var observableNumber = exports.observableNumber = observableString.map(function (s) {
  return s.length;
});
var obsX = exports.obsX = (0, _Observable2.default)("Heia!");
var obsY = exports.obsY = (0, _Observable2.default)(89);
var kiss = exports.kiss = (0, _Observable2.default)(["Paul", "Ace"]);

var Player = exports.Player = function Player($arg0, $arg1) {
  _classCallCheck(this, Player);

  this.name = $arg0;
  this.age = $arg1;
};

var names = exports.names = (0, _Observable2.default)();
names.replaceAll([new Player("John", 71), new Player("Ringo", 45), new Player("Paul", 69)]);
var numNames = exports.numNames = names.count(function (n) {
  return n.name.length > 4;
});
var obsZ = exports.obsZ = obsY.map(function (old) {
  return old + 1;
});
var plainObservable = exports.plainObservable = (0, _Observable2.default)();
plainObservable.value = "Fuckfaaaace2";
var obsU = obsZ.map(function (tupledArg) {
  var p, idx;
  return p = tupledArg[0], idx = tupledArg[1], p + idx;
});

var buttonClicked = exports.buttonClicked = function (args) {
  return console.log(JSON.stringify(args));
};

console.log(obsX.value);
console.log(obsY.value);
var X = exports.X = "Hello again from F#!";