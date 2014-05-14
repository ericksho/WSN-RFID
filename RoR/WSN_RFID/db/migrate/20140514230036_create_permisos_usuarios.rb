class CreatePermisosUsuarios < ActiveRecord::Migration
  def change
    create_table :permisos_usuarios, id: false do |t|
    	t.references :permiso
    	t.references :usuario
    end

    add_index :permisos_usuarios, [:permiso_id, :usuario_id], unique: true
  end
end