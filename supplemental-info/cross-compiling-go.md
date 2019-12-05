# Cross-Compiling in Go

The Go language supports many build target architectures and operating systems out of the box.  That means you don't have to fiddle around setting up exotic toolchains, you just specify the architecture and operating system you want.

Go builds statically-linked binaries, with no runtime dependencies, by default.  That means you can build a binary for another architecture/OS, copy it to that environment, and run it immediately.

If you execute `go build` with no other arguments, it will target the operating system and architecture you're currently running in.

## Specifying Build Targets

### From Windows

In Windows, it's easiest to place your commands in a batch file.

Example, targeting 64-bit Windows:

```
SET GOOS=windows
SET GOARCH=amd64

go build -ldflags "-s -w"
```

Example, targeting 64-bit Linux:

```
SET GOOS=linux
SET GOARCH=amd64

go build -ldflags "-s -w"
```

Example, targeting 32-bit Linux:

```
SET GOOS=linux
SET GOARCH=386

go build -ldflags "-s -w"
```

### From Linux

In Linux, you can set your build targets from a single line.

Example, targeting 64-bit Windows:

```
env GOOS=windows GOARCH=amd64 go build -v
```

Example, targeting 64-bit Linux:

```
env GOOS=linux GOARCH=amd64 go build -v
```

Example, targeting 32-bit Linux:

```
env GOOS=linux GOARCH=386 go build -v
```

## Supported Architectures and Operating Systems

This is not a complete list.  It just represents some of the more common targets.

**Note:**  Targeting architecture `arm` and operating system `linux` lets you build for the Raspberry Pi, and targeting architecture `wasm` and operating system `js` targets WebAssembly.

### Architectures

* 386
* amd64
* arm
* mips
* sparc
* sparc64
* wasm

### Operating Systems

* android
* darwin
* freebsd
* js
* linux
* openbsd
* windows
