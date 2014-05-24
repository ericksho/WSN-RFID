class AddAccesosToPermisos < ActiveRecord::Migration
  def change
  	add_column :permisos, :acceso_articulo, :boolean
  	add_column :permisos, :acceso_lectura, :boolean
  	add_column :permisos, :acceso_lector, :boolean
  	add_column :permisos, :acceso_paquete, :boolean
  	add_column :permisos, :acceso_usuario, :boolean
  	add_column :permisos, :acceso_permiso, :boolean
  	add_column :permisos, :acceso_alerta, :boolean
  	add_column :permisos, :acceso_vehiculo, :boolean
  	add_column :permisos, :acceso_persona, :boolean
    add_column :permisos, :acceso_atributo, :boolean
  end
end
