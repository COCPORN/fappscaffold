"use strict";

Object.defineProperty(exports, "__esModule", {
  value: true
});
exports.X = exports.stringResult = exports.seqOdd = exports.seq = exports.buttonClicked = exports.add = exports.o2 = exports.o1 = undefined;

var _Observable = require("FuseJS/Observable");

var _Observable2 = _interopRequireDefault(_Observable);

var _fableCore = require("fable-core");

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }

var o1 = exports.o1 = (0, _Observable2.default)(3);
var o2 = exports.o2 = (0, _Observable2.default)("PenguinFucker");
var o3 = (0, _Observable2.default)("");
console.log("o1: " + JSON.stringify(o1));
console.log("o2: " + JSON.stringify(o2));
console.log("o3: " + JSON.stringify(o3));
console.log("o1 val: " + JSON.stringify(o1.value));

var add = exports.add = function (a, b) {
  return a + b;
};

var buttonClicked = exports.buttonClicked = function (args) {
  console.log("BUTTON CLICKED! " + JSON.stringify(args));
  o1.value = "CLICKED!";
};

var seq = exports.seq = _fableCore.Seq.init(5, function (n) {
  return n * 10;
});

var seqOdd = exports.seqOdd = (0, _Observable2.default)(_fableCore.String.concat(", ", _fableCore.Seq.map(function (value) {
  return value.toString();
}, _fableCore.Seq.filter(function (n) {
  return n > 20;
}, seq))));

var stringResult = exports.stringResult = _fableCore.Seq.fold(function (acc, elem) {
  return acc + elem;
}, 0, seq).toString();

var X = exports.X = "Hello again again from F#!" + add(5, 6).toString() + " " + stringResult;