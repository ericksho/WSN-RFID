# This file should contain all the record creation needed to seed the database with its default values.
# The data can then be loaded with the rake db:seed (or created alongside the db with db:setup).
#
# Examples:
#
#   cities = City.create([{ name: 'Chicago' }, { name: 'Copenhagen' }])
#   Mayor.create(name: 'Emanuel', city: cities.first)

p = Permiso.create(titulo: "Administrador", acceso_articulo: true, acceso_lectura: true, acceso_lector: true, acceso_alerta: true, acceso_permiso: true, acceso_persona: true, acceso_usuario: true, acceso_vehiculo: true)
u1 = Usuario.create(nombre: "Esteban", apellido: "Piñones", email: "cabasp@gmail.com", password: "123123123", password_confirmation: "123123123", cargo: "Administrador")
u2 = Usuario.create(nombre: "Ignacio", apellido: "Carmach", email: "icarmach@gmail.com", password: "123123123", password_confirmation: "123123123", cargo: "Administrador")
u3 = Usuario.create(nombre: "Erick", apellido: "Svec", email: "ericksho@gmail.com", password: "123123123", password_confirmation: "123123123", cargo: "Administrador")
u4 = Usuario.create(nombre: "Tomás", apellido: "Martinez", email: "t.martinezg@gmail.com", password: "123123123", password_confirmation: "123123123", cargo: "Administrador")

u1.permisos << p
u2.permisos << p
u3.permisos << p
u4.permisos << p