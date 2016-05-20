"use strict";

Object.defineProperty(exports, "__esModule", {
  value: true
});
exports.Fetch = exports.Args = exports.Json = exports.Console = undefined;

var _fableCore = require("fable-core");

var Console = exports.Console = function ($exports) {
  return $exports;
}({});

var Json = exports.Json = function ($exports) {
  return $exports;
}({});

var Args = exports.Args = function ($exports) {
  var toString = $exports.toString = function (arg) {
    return function () {
      var clo1;
      return clo1 = _fableCore.String.fsFormat("%O")(function (x) {
        return x;
      }), function (arg10) {
        return clo1(arg10);
      };
    }()(arg);
  };

  return $exports;
}({});

var Fetch = exports.Fetch = function ($exports) {
  var fetch = $exports.fetch = function (uri, request) {
    throw "JS only";
  };

  return $exports;
}({});