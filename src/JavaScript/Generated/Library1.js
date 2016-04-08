"use strict";

Object.defineProperty(exports, "__esModule", {
  value: true
});
exports.X = exports.buttonClicked = exports.plainObservable = exports.obsU = exports.obsZ = exports.numNames = exports.names = exports.obsY = exports.obsX = undefined;

var _Observable = require("FuseJS/Observable");

var _Observable2 = _interopRequireDefault(_Observable);

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }

var obsX = exports.obsX = (0, _Observable2.default)("Heia!");
var obsY = exports.obsY = (0, _Observable2.default)(89);
var names = exports.names = (0, _Observable2.default)("");
names.replaceAll(["John", "Paul", "Ringo"]);
var numNames = exports.numNames = names.count(function (n) {
  return n.length > 4;
});
var obsZ = exports.obsZ = obsY.map(function (old) {
  return old + 1;
});
var obsU = exports.obsU = obsZ.map(function (tupledArg) {
  var p, idx;
  return p = tupledArg[0], idx = tupledArg[1], p + idx;
});
var plainObservable = exports.plainObservable = (0, _Observable2.default)();

var buttonClicked = exports.buttonClicked = function (args) {
  return console.log(JSON.stringify(args));
};

console.log(obsX.value);
console.log(obsY.value);
var X = exports.X = "Hello again from F#!";