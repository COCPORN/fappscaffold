"use strict";

Object.defineProperty(exports, "__esModule", {
  value: true
});
exports.Lifecycle = exports.Args = exports.Json = exports.Console = undefined;

var _fableCore = require("fable-core");

var _Lifecycle = require("FuseJS/Lifecycle");

var _Lifecycle2 = _interopRequireDefault(_Lifecycle);

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }

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

var Lifecycle = exports.Lifecycle = function ($exports) {
  var onEnteringForeground = $exports.onEnteringForeground = function (action) {
    _Lifecycle2.default.onEnteringForeground = action;
  };

  var onEnteringBackground = $exports.onEnteringBackground = function (action) {
    _Lifecycle2.default.onEnteringBackground = action;
  };

  return $exports;
}({});